using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IBase_SysRoleBusiness : IDependency
    {
        #region �ⲿ�ӿ�

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        List<Base_SysRole> GetDataList(string condition, string keyword, Pagination pagination);

        /// <summary>
        /// ��ȡָ���ĵ�������
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        Base_SysRole GetTheData(string id);

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="newData">����</param>
        void AddData(Base_SysRole newData);

        /// <summary>
        /// ��������
        /// </summary>
        void UpdateData(Base_SysRole theData);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        void DeleteData(List<string> ids);

        /// <summary>
        /// ����Ȩ��
        /// </summary>
        /// <param name="roleId">��ɫId</param>
        /// <param name="permissions">Ȩ��ֵ</param>
        void SavePermission(string roleId, List<string> permissions);

        #endregion

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}