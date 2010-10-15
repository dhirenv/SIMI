using System;

namespace ContactManager.Model
{
    [Serializable]
    public class Contact : Notifier
    {
        private Address _address = new Address();

        public Address Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }
        private string _cellPhone;

        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; OnPropertyChanged("CellPhone"); }
        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); OnPropertyChanged("LookupName"); }
        }
        private string _homePhone;

        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; OnPropertyChanged("HomePhone"); }
        }
        private Guid _id = Guid.Empty;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }
        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged("ImagePath"); }
        }
        private string _jobTitle;

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; OnPropertyChanged("JobTitle"); }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); OnPropertyChanged("LookupName"); }
        }
        private string _officePhone;

        public string OfficePhone
        {
            get { return _officePhone; }
            set { _officePhone = value; OnPropertyChanged("OfficePhone"); }
        }
        private string _organization;

        public string Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }
        private string _primaryEmail;

        public string PrimaryEmail
        {
            get { return _primaryEmail; }
            set { _primaryEmail = value; OnPropertyChanged("PrimaryEmail"); }
        }
        private string _secondaryEmail;

        public string SecondaryEmail
        {
            get { return _secondaryEmail; }
            set { _secondaryEmail = value; OnPropertyChanged("SecondaryEmail"); }
        }

        public string LookupName
        {
            get { return string.Format("{0}, {1}", _lastName, _firstName); }
        }

        public override string ToString()
        {
            return LookupName;
        }

        public override bool Equals(object obj)
        {
            Contact other = obj as Contact;
            return other != null && other.Id == Id;
        }
    }
}
