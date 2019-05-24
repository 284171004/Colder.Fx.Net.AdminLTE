using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IBase_AppSecretBusiness : IDependency
    {
        #region �ⲿ�ӿ�

        List<Base_AppSecret> GetDataList(string condition, string keyword, Pagination pagination);

        /// <summary>
        /// ��ȡָ���ĵ�������
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        Base_AppSecret GetTheData(string id);

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="newData">����</param>
        void AddData(Base_AppSecret newData);

        /// <summary>
        /// ��������
        /// </summary>
        void UpdateData(Base_AppSecret theData);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        void DeleteData(List<string> ids);

        /// <summary>
        /// ����Ȩ��
        /// </summary>
        /// <param name="appId">Ӧ��Id</param>
        /// <param name="permissions">Ȩ��ֵ</param>
        void SavePermission(string appId, List<string> permissions);

        #endregion

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}