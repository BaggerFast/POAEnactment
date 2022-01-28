using System;
using System.Collections.Generic;
using System.Text;

namespace PAODb
{
    /// <summary>
    /// ������� "�������� ��������������� ����"
    /// </summary>
    public class ManagerPassport : BaseEntity
    {
        #region public and private fields and properties

        /// <summary>
        /// ����� ��������
        /// </summary>
        public virtual string Series { get; set; }
        /// <summary>
        /// ����� ���������
        /// </summary>
        public virtual string Number { get; set; }
        /// <summary>
        /// ���� ������
        /// </summary>
        public virtual DateTime DateIssue { get; set; }
        /// <summary>
        /// ����� ������
        /// </summary>
        public virtual string PlaceIssue { get; set; }
        /// <summary>
        /// �������������� ����
        /// </summary>
        public virtual Manager Manager { get; set; }
        #endregion

    }

}
