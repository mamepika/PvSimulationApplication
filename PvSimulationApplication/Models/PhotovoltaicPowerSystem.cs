using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PvSimulationApplication.Models.Entites;
using PvSimulationApplication.Models.Repositories;

namespace PvSimulationApplication.Models
{
    /// <summary>
    /// 太陽光発電システム
    /// </summary>
    class PhotovoltaicPowerSystem
    {
        public PhotovoltaicPowerSystem(string cityId,int direction,int incline)
        {
            ISolarRadiationRepository solarRepo = new SolarRadiationRepository();
            solarLadiation = solarRepo.FindByIdAndAngle(cityId, direction, incline);
            
        }

        public City city { get; set; }
        //方位角
        public int directionAngle { get; set; }
        //傾斜角
        public int inclineAngle { get; set; }
        //モジュール台数
        public int moduleCount { get; set; }
        //モジュール出力
        public int moduleGeneration { get; set; }

        private SolarRadiation solarLadiation;

        /// <summary>
        /// 1月の発電量
        /// </summary>
        /// <returns></returns>
        public double GetJanuaryGeneration()
        {
            return solarLadiation.January * 31 * 0.90 * 0.95 * moduleCount * moduleGeneration;
        }
        /// <summary>
        /// 2月の発電量
        /// </summary>
        /// <returns></returns>
        public double GetFebruaryGeneration()
        {
            return solarLadiation.February * 31 * 0.90 * 0.95 * moduleCount * moduleGeneration;
        }
        /// <summary>
        /// 3月の発電量
        /// </summary>
        /// <returns></returns>
        public double GetMarchGeneration()
        {
            return solarLadiation.March * 31 * 0.90 * 0.95 * moduleCount * moduleGeneration;
        }

        public double GetAprilGeneration()
        {
            return solarLadiation.April * 31 * 0.90 * 0.95 * moduleCount * moduleGeneration;
        }

        public double GetMayGeneration()
        {
            return solarLadiation.May * 31 * 0.85 * 0.95 * moduleCount * moduleGeneration;
        }

        public double GetJuneGeneration()
        {
            return solarLadiation.June * 31 * 0.85 * 0.95 * moduleCount * moduleGeneration;
        }
        public double GetJulyGeneration()
        {
            return solarLadiation.July * 31 * 0.80 * 0.95 * moduleCount * moduleGeneration;
        }

        /// <summary>
        /// 8月の発電量
        /// </summary>
        /// <returns></returns>
        public double GetAugustGeneration()
        {
            return solarLadiation.August * 31 * 0.80 * 0.95 * moduleCount * moduleGeneration;
        }

        /// <summary>
        /// 年間総発電量を返す
        /// </summary>
        /// <returns>年間総発電量</returns>
        public double GetTotalGeneratedEnergy()
        {
            
            return 0;
        }

        /// <summary>
        /// 月別発電量を返す
        /// </summary>
        /// <returns></returns>
        public double GetGeneratedEnergyByMonth()
        {
            return 0;
        }
    }
}
