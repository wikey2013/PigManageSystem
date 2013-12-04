using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace PigManagerSystem.Unity
{
    public class ComHelp
    {
        /// <summary>
        /// 检查字符是否为整型
        /// </summary>
        /// <param name="textStr"></param>
        /// <returns></returns>
        public static bool ValidateInt(string textStr)
        {
            string regexText = "^[0-9]*$";
            Regex intRegex = new Regex(regexText);
           bool result=intRegex.IsMatch(textStr);
           return result;
        }

        public static bool SetAutoRun(string keyName, string filePath) 
        { 
            try 
            { 
                RegistryKey runKey = Registry.LocalMachine.OpenSubKey(@"\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true); 
                runKey.SetValue(keyName, filePath); 
                runKey.Close(); 
            } catch 
            { 
                return false;
            } 
            return true; 
        }

        public static bool DeleteAutoRun(string keyName)
        {
            try
            {
                RegistryKey runKey = Registry.LocalMachine.OpenSubKey(@"\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                runKey.DeleteValue(keyName);
                runKey.Close();
            }
            catch
            {
                return false;
            }
            return true;
        } 
    }
}
