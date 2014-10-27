﻿// <copyright file="StartMeasurementDialogViewModel.cs" company="LS Instruments">
//     Copyright (c) 2014 LS Instruments. All rights reserved.
// </copyright>
namespace MahAppsMetroCaliburnTest.ViewModels.Dialogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestMahAppsDialogViewModel : DialogViewModel<string>
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                this.NotifyOfPropertyChange(() => FirstName);
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
                this.NotifyOfPropertyChange(() => LastName);
            }
        }

        private string helloMessage;
        public string HelloMessage
        {
            get
            {
                return this.helloMessage;
            }
            set
            {
                this.helloMessage = value;
                this.NotifyOfPropertyChange(() => HelloMessage);
            }
        }

        public void SayHello()
        {
            this.HelloMessage = String.Format("Hello, {0} {1}", firstName, lastName);
        }
    }
}
