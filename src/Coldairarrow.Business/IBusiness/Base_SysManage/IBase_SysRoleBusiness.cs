using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;
using static Coldairarrow.Entity.Base_SysManage.EnumType;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IBase_SysRoleBusiness
    {
        #region �ⲿ�ӿ�

        List<Base_SysRoleDTO> GetDataList(Pagination pagination, string roldId = null, string roleName = null);

        /// <summary>
        /// ��ȡָ���ĵ�������
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        Base_SysRole GetTheData(string id);

        Base_SysRoleDTO GetTheInfo(string id);

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

    public class Base_SysRoleDTO: Base_SysRole
    {
        public RoleType? RoleType { get => RoleName?.ToEnum<RoleType>(); }
    }
}