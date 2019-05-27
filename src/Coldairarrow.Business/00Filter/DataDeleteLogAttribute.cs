﻿using Castle.DynamicProxy;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using static Coldairarrow.Entity.Base_SysManage.EnumType;

namespace Coldairarrow.Business
{
    public class DataDeleteLogAttribute : WriteDataLogAttribute
    {
        public DataDeleteLogAttribute(LogType logType, string dataName, string nameField)
            : base(logType, dataName, nameField)
        {
        }

        private List<object> _deleteList { get; set; }

        public override void OnActionExecuting(IInvocation invocation)
        {
            List<string> ids = invocation.Arguments[0] as List<string>;
            var q = invocation.InvocationTarget.GetType().GetMethod("GetIQueryable").Invoke(invocation.InvocationTarget, new object[] { }) as IQueryable;
            _deleteList = q.Where("@0.Contains(outerIt.Id)", ids).CastToList<object>();
        }

        public override void OnActionExecuted(IInvocation invocation)
        {
            string names = string.Join(",", _deleteList.Select(x => x.GetPropertyValue(_nameField)?.ToString()));
            BusHelper.WriteSysLog($"删除{_dataName}:{names}", _logType);
        }
    }
}
