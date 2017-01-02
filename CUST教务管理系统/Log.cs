﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CUST教务管理系统
{
    class Log
    {
        string path = "";
    public Log(string path)
        {
            this.path = path;
            if (!File.Exists(path)) //系统信息
            {
                StreamWriter log = new StreamWriter(path, true);
                log.WriteLine("OSVersion：" + Environment.OSVersion.ToString());
                log.WriteLine("MachineName:" + Environment.MachineName.ToString());
                log.WriteLine("User:" + Environment.UserName.ToString());
                log.WriteLine(".Net Version:" + Environment.Version.ToString());
                log.WriteLine("Is x64:" + Environment.Is64BitOperatingSystem.ToString());
                log.Close();
            }
        }
        public void loginWrite(string str)  //登录日志
        {
            StreamWriter log = new StreamWriter(path, true);
            log.WriteLine("*");
            log.WriteLine(System.DateTime.Now.ToLongDateString());
            log.Write("[" + System.DateTime.Now.ToLongTimeString() + "]");
            log.WriteLine(str);
            log.Close();
        }
        public void write(string str)   //其它日志
        {
            StreamWriter log = new StreamWriter(path, true);
            log.Write("[" + System.DateTime.Now.ToLongTimeString() + "]");
            log.WriteLine(str);
            log.Close();
        }
    }
}
