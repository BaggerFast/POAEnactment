using System;
using System.Collections.Generic;
using System.Text;

namespace PAODb
{
    /// <summary>
    /// ������� "�������������� ����"
    /// </summary>
    public class Manager : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// ���
        /// </summary>
        public virtual string FirstName { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public virtual string LastName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public virtual string MiddleName { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public virtual ManagerPassport Passport{ get; set; }
        #endregion

    }

}
