using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public class Base_SysLogBusiness : BaseBusiness<Base_SysLog>, IBase_SysLogBusiness, IDependency
    {
        #region �ⲿ�ӿ�

        /// <summary>
        /// ��ȡ��־�б�
        /// </summary>
        /// <param name="logContent">��־����</param>
        /// <param name="logType">��־����</param>
        /// <param name="opUserName">�������û���</param>
        /// <param name="startTime">��ʼʱ��</param>
        /// <param name="endTime">����ʱ��</param>
        /// <param name="pagination">��ҳ����</param>
        /// <returns></returns>
        public List<Base_SysLog> GetLogList(
            Pagination pagination,
            string logContent,
            string logType,
            string opUserName,
            DateTime? startTime,
            DateTime? endTime)
        {
            return LoggerFactory.GetLogger().GetLogList(pagination, logContent, logType, opUserName, startTime, endTime);
        }

        #endregion

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}