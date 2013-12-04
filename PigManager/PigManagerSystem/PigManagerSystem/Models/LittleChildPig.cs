using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigManagerSystem.Models
{
   public class LittleChildPig
    {
        public int Id { get; set; }

        public int MotherPigId{ get; set; }

        public bool IsDeath { get; set; }

        public string PigType { get; set; }
    }

    public enum PigType
    {
        /// <summary>
        /// 健仔
        /// </summary>
        goodPig,

        /// <summary>
        /// 弱仔
        /// </summary>
        weakPig,

        /// <summary>
        /// 死胎
        /// </summary>
        deathPig,

        /// <summary>
        /// 木乃伊
        /// </summary>
        mummyPig,

        /// <summary>
        /// 畸形
        /// </summary>
        deformityPig
    }
}
