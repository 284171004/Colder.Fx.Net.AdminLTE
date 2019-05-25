using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IBase_DatabaseLinkBusiness
    {
        #region �ⲿ�ӿ�

        /// <summary>
        /// ��ȡ�����б�
        /// </summary>
        /// <param name="condition">��ѯ����</param>
        /// <param name="keyword">�ؼ���</param>
        /// <returns></returns>
        List<Base_DatabaseLink> GetDataList(string condition, string keyword, Pagination pagination);

        /// <summary>
        /// ��ȡָ���ĵ�������
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        Base_DatabaseLink GetTheData(string id);

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="newData">����</param>
        void AddData(Base_DatabaseLink newData);

        /// <summary>
        /// ��������
        /// </summary>
        void UpdateData(Base_DatabaseLink theData);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        void DeleteData(List<string> ids);

        #endregion

        #region ˽�г�Ա

        #endregion

        #region ����ģ��

        #endregion
    }
}