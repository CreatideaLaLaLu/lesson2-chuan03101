using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taoyuan.Sa.Fund.Service
{
    /// <summary>
    /// 作業service
    /// </summary>
    class NamingRuleService
    {

        /// <summary>
        /// 測試Function
        /// </summary>
        /// <param name="index">傳入值</param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            #region 錯誤1

            // bad
            switch (index)
            {
                case 1: break;
                default: break;
            }

            // good
            switch (index)
            {
                case 1:
                    break;
                default:
                    break;
            }

            #endregion

            #region 錯誤2

            // bad
            if (index == 0) DoTrue();
            else
                DoFalse();

            // good
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                DoFalse();
            }

            #endregion

            #region 錯誤3

            // bad
            if (DoTrue() == true) { DoTrue(); }

            // good
            if (DoTrue() == true)
            {
                DoTrue();
            }

            #endregion

            #region 錯誤4

            // bad
            //return (index * (index + 1) / 2);

            // good
            var result = index * (index + 1) / 2;
            return result;

            #endregion
        }

        /// <summary>
        /// 對的事件
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }

        /// <summary>
        /// 錯的事件
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }

        /// <summary>
        /// 測試字串Function
        /// </summary>
        /// <param name="value">The value.</param>
        public void TestStringFunction(string value)
        {
            #region 錯誤5

            // bad
            string NewString = "ABCDEFG"; //新字串

            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            // bad
            string newStringGood = "ABCDEFG"; //新字串
            if (!string.IsNullOrEmpty(newStringGood))
            {
                newStringGood = newStringGood.Replace("A", ",").Replace("B", "_").Replace("C", " ");
            }

            // good
            string newStringGood2 = "ABCDEFG"; //新字串
            if (!string.IsNullOrEmpty(newStringGood2))
            {
                newStringGood2 = new StringBuilder(newStringGood2).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }

            #endregion
        }
        
    }
}
