﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using PvSimulationApplication.Models;
using PvSimulationApplication.Models.Entites;
using PvSimulationApplication.Models.Repositories;

namespace PvSimulationApplication.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private CityRepository cityRepo = new CityRepository();
        private MetropolisRepository metroRepo = new MetropolisRepository();
        private PhotovoltaicModuleRepository photoRepo = new PhotovoltaicModuleRepository();

        public void Initialize()
        {
            //Messenger.Raise(new InformationMessage("message", "caption", "Information"));  
        }

        public void Calc()
        {
            Console.WriteLine("計算結果は" + 10 + "です。");
        }


        #region 太陽光モジュールプロパティ変更通知
        private List<PhotovoltaicModule> _photvoltaicModules;

        public List<PhotovoltaicModule> PhotovoltaicModules
        {
            get
            {
                if (_photvoltaicModules == null)
                {
                    _photvoltaicModules = photoRepo.FindAll();
                }
                return _photvoltaicModules;
            }
        }
        #endregion


        #region 都市プロパティ変更通知
        private List<Metropolis> metropolises;
        public List<Metropolis> Metropolises
        {
            get
            {
                if (metropolises == null)
                {
                    metropolises = metroRepo.FindAll();
                }
                return this.metropolises;
            }
        }
        #endregion

        #region 市町村変更通知プロパティ
        public List<City> cities;
        public List<City> Cities
        {
            get
            {
                return this.cities;
            }
        }
        /// <summary>
        /// 都市・県が選択された際に選択した都市に属する市町村を市町村プロパティに設定する
        /// </summary>
        private void SetCitiesByMetropolisId()
        {
            cities = cityRepo.FindByMetroPolisId(selectedMetropolis.MetropolisId);

            RaisePropertyChanged("Cities");
        }
        #endregion

        #region selectedMetropolis　選択された都市
        private Metropolis selectedMetropolis;
        public Metropolis SelectedMetropolis
        {
            set
            {
                selectedMetropolis = value;
                SetCitiesByMetropolisId();
            }
        }
        #endregion

        private int _inclineAngle;

        public int InclineAngle
        {
            set
            {
                _inclineAngle = value;
            }
        }

        private int _directionAngle;

        public int DirectionAngle
        {
            set
            {
                _directionAngle = value;
            }
        }

        #region 最初のコメント
        /* コマンド、プロパティの定義にはそれぞれ 
         * 
         *  lvcom   : ViewModelCommand
         *  lvcomn  : ViewModelCommand(CanExecute無)
         *  llcom   : ListenerCommand(パラメータ有のコマンド)
         *  llcomn  : ListenerCommand(パラメータ有のコマンド・CanExecute無)
         *  lprop   : 変更通知プロパティ(.NET4.5ではlpropn)
         *  
         * を使用してください。
         * 
         * Modelが十分にリッチであるならコマンドにこだわる必要はありません。
         * View側のコードビハインドを使用しないMVVMパターンの実装を行う場合でも、ViewModelにメソッドを定義し、
         * LivetCallMethodActionなどから直接メソッドを呼び出してください。
         * 
         * ViewModelのコマンドを呼び出せるLivetのすべてのビヘイビア・トリガー・アクションは
         * 同様に直接ViewModelのメソッドを呼び出し可能です。
         */

        /* ViewModelからViewを操作したい場合は、View側のコードビハインド無で処理を行いたい場合は
         * Messengerプロパティからメッセージ(各種InteractionMessage)を発信する事を検討してください。
         */

        /* Modelからの変更通知などの各種イベントを受け取る場合は、PropertyChangedEventListenerや
         * CollectionChangedEventListenerを使うと便利です。各種ListenerはViewModelに定義されている
         * CompositeDisposableプロパティ(LivetCompositeDisposable型)に格納しておく事でイベント解放を容易に行えます。
         * 
         * ReactiveExtensionsなどを併用する場合は、ReactiveExtensionsのCompositeDisposableを
         * ViewModelのCompositeDisposableプロパティに格納しておくのを推奨します。
         * 
         * LivetのWindowテンプレートではViewのウィンドウが閉じる際にDataContextDisposeActionが動作するようになっており、
         * ViewModelのDisposeが呼ばれCompositeDisposableプロパティに格納されたすべてのIDisposable型のインスタンスが解放されます。
         * 
         * ViewModelを使いまわしたい時などは、ViewからDataContextDisposeActionを取り除くか、発動のタイミングをずらす事で対応可能です。
         */

        /* UIDispatcherを操作する場合は、DispatcherHelperのメソッドを操作してください。
         * UIDispatcher自体はApp.xaml.csでインスタンスを確保してあります。
         * 
         * LivetのViewModelではプロパティ変更通知(RaisePropertyChanged)やDispatcherCollectionを使ったコレクション変更通知は
         * 自動的にUIDispatcher上での通知に変換されます。変更通知に際してUIDispatcherを操作する必要はありません。
         */
        #endregion
    }
}
