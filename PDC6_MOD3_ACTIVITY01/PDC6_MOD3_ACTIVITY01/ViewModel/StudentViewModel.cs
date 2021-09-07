using System;
using System.Collections.Generic;
using System.Text;
using PDC6_MOD3_ACTIVITY01.Model;
using Xamarin.Forms;
using System.ComponentModel;

namespace PDC6_MOD3_ACTIVITY01.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }
        public string StudentCodeEntry { get; set; }
        public string StudentCodeDisplay { get; set; }
        public string StudentTitleEntry { get; set; }
        public string StudentTitleDisplay { get; set; }
        public string StudentUnitEntry { get; set; }
        public string StudentUnitDisplay { get; set; }
        public Command ClearEntry { get; set; }

        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student()
                {
                    SubjectCode = StudentCodeEntry,
                };

                StudentCodeDisplay = StudentCodeEntry;

                StudentTitleDisplay = StudentTitleEntry;
                StudentUnitDisplay = StudentUnitEntry;
                
                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentTitleDisplay));
                
                OnPropertyChanged(nameof(StudentUnitDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry));

                OnPropertyChanged(nameof(StudentTitleEntry));
                OnPropertyChanged(nameof(StudentUnitEntry));
            });

            ClearEntry = new Command(() =>
            {
                StudentCodeEntry = "";
                StudentCodeDisplay = "";
                StudentTitleDisplay = "";
                StudentUnitDisplay = "";
                StudentUnitEntry = "";
                StudentTitleEntry = "";

                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentTitleDisplay));

                OnPropertyChanged(nameof(StudentUnitDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry));

                OnPropertyChanged(nameof(StudentTitleEntry));
                OnPropertyChanged(nameof(StudentUnitEntry));



            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
