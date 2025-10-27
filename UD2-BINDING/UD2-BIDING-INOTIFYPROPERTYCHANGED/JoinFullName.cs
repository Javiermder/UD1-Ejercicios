using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UD2_BIDING_INOTIFYPROPERTYCHANGED
{
    public class JoinFullName : INotifyPropertyChanged
    {
        private String name;
        private String lastname;
        private String fullname;

        //Propiedades
        public String? Name {
            get { return name; }
            set{
                name = value;
                NotifyPropertyChanged(nameof(FullName));
                
            } 
        }
        public String? LastName {
            get { return lastname; }
            set{
                lastname = value;
                NotifyPropertyChanged(nameof(FullName));
                
            } 
        }
        public String? FullName
        {
            get
            {
                fullname = name + " " + lastname;
                return fullname;
            }


            set
            {
                

            } 
        }



        public JoinFullName(string name, string lastname) {

            Name = name;
            LastName = lastname;
            FullName = name + " " + lastname;

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
