using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PigManagerSystem
{
   public class ChildPigInfo
    {
       /// <summary>
       /// ID值
       /// </summary>
        public int Id { get; set; }

       /// <summary>
        /// 耳号:
       /// </summary>
        public int PigId { get; set; }

       /// <summary>
        /// 转入保育舍日
       /// </summary>
        public int InHouseDate { get; set; }

       /// <summary>
        /// 转入保育舍周
       /// </summary>
        public int InHouseWeek { get; set; }

       /// <summary>
        /// 转入栏
       /// </summary>
        public int InPigstyNumber { get; set; }

       /// <summary>
        /// 转入头数
       /// </summary>
        public int InCount { get; set; }

       /// <summary>
        /// 日龄
       /// </summary>
        public int DateAge { get; set; }

       /// <summary>
        /// 死亡登记
       /// </summary>
        public bool DeathRegister { get; set; }

       /// <summary>
        /// 销售登记
       /// </summary>
        public bool SellRegister { get; set; }

       /// <summary>
        /// 转往育肥栏日
       /// </summary>
        public int TurnInPigstyDate { get; set; }

       /// <summary>
        /// 转往育肥栏周次
       /// </summary>
        public int TurnInPigstyWeek { get; set; }

       /// <summary>
        /// 转出头数
       /// </summary>
        public int TurnOutCount { get; set; }

       /// <summary>
        /// 保育阶段成活率
       /// </summary>
        public int SurvivalRate { get; set; }

       /// <summary>
        /// 备注
       /// </summary>
        public string Remark { get; set; }
    }
}
