using Coldairarrow.Entity.Base_SysManage;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Base_SysManage
{
    public interface IBase_UserBusiness : IDependency
    {
        List<Base_UserDTO> GetDataList(string condition, string keyword, Pagination pagination);

        /// <summary>
        /// ��ȡָ���ĵ�������
        /// </summary>
        /// <param name="id">����</param>
        /// <returns></returns>
        Base_User GetTheData(string id);

        void AddData(Base_User newData);

        /// <summary>
        /// ��������
        /// </summary>
        void UpdateData(Base_User theData);
        void SetUserRole(string userId, List<string> roleIds);

        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="theData">ɾ��������</param>
        void DeleteData(List<string> ids);

        /// <summary>
        /// ��ȡ��ǰ��������Ϣ
        /// </summary>
        /// <returns></returns>
        Base_UserDTO GetCurrentUser();

        /// <summary>
        /// ��ȡ�û���Ϣ
        /// </summary>
        /// <param name="userId">�û�Id</param>
        /// <returns></returns>
        Base_UserDTO GetTheUser(string userId);

        List<string> GetUserRoleIds(string userId);

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="oldPwd">������</param>
        /// <param name="newPwd">������</param>
        AjaxResult ChangePwd(string oldPwd, string newPwd);

        /// <summary>
        /// ����Ȩ��
        /// </summary>
        /// <param name="userId">�û�Id</param>
        /// <param name="permissions">Ȩ��ֵ</param>
        void SavePermission(string userId, List<string> permissions);

        List<Base_User> BuildSelectResult(string selectedValueJson, string q, string textFiled, string valueField);
    }

    public class Base_UserDTO : Base_User
    {
        public string RoleNames { get => string.Join(",", RoleNameList); }

        public List<string> RoleIdList { get; set; }

        public List<string> RoleNameList { get; set; }

        public EnumType.RoleType RoleType
        {
            get
            {
                int type = 0;

                var values = typeof(EnumType.RoleType).GetEnumValues();
                foreach (var aValue in values)
                {
                    if (RoleNames.Contains(aValue.ToString()))
                        type += (int)aValue;
                }

                return (EnumType.RoleType)type;
            }
        }
    }
}