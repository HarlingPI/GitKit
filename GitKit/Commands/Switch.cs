using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitKit.Commands
{
    /// <summary>
    /// 作者:   Harling
    /// 时间:   2025/5/27 12:06:13
    /// 备注:   此文件通过PIToolKit模板创建
    /// </summary>
    /// <remarks></remarks>
    public class Switch : Command
    {
        public Switch(string workingFolder) : base(workingFolder)
        {
        }

        public override void Excute(string[] projects, uint retry, params string[] args)
        {
            var cmd = $"switch {string.Join(' ', args)}";
            for (int i = 0; i < projects.Length; i++)
            {
                GitLib.ExcuteCommand(projects[i], cmd, retry);
            }
        }
    }
}