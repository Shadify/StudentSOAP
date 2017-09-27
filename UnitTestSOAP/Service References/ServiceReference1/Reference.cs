﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestSOAP.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/StudentSOAP")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/StudentSOAP")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SemesterField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Semester {
            get {
                return this.SemesterField;
            }
            set {
                if ((this.SemesterField.Equals(value) != true)) {
                    this.SemesterField = value;
                    this.RaisePropertyChanged("Semester");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        UnitTestSOAP.ServiceReference1.CompositeType GetDataUsingDataContract(UnitTestSOAP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(UnitTestSOAP.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        UnitTestSOAP.ServiceReference1.Student AddStudent(string name, int semester, int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> AddStudentAsync(string name, int semester, int age);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        UnitTestSOAP.ServiceReference1.Student FindStudent(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudent", ReplyAction="http://tempuri.org/IService1/FindStudentResponse")]
        System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> FindStudentAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        void DeleteStudent(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteStudent", ReplyAction="http://tempuri.org/IService1/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        UnitTestSOAP.ServiceReference1.Student EditStudent(UnitTestSOAP.ServiceReference1.Student studentA, UnitTestSOAP.ServiceReference1.Student studentB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> EditStudentAsync(UnitTestSOAP.ServiceReference1.Student studentA, UnitTestSOAP.ServiceReference1.Student studentB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudent", ReplyAction="http://tempuri.org/IService1/GetAllStudentResponse")]
        UnitTestSOAP.ServiceReference1.Student[] GetAllStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudent", ReplyAction="http://tempuri.org/IService1/GetAllStudentResponse")]
        System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student[]> GetAllStudentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : UnitTestSOAP.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<UnitTestSOAP.ServiceReference1.IService1>, UnitTestSOAP.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public UnitTestSOAP.ServiceReference1.CompositeType GetDataUsingDataContract(UnitTestSOAP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(UnitTestSOAP.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public UnitTestSOAP.ServiceReference1.Student AddStudent(string name, int semester, int age) {
            return base.Channel.AddStudent(name, semester, age);
        }
        
        public System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> AddStudentAsync(string name, int semester, int age) {
            return base.Channel.AddStudentAsync(name, semester, age);
        }
        
        public UnitTestSOAP.ServiceReference1.Student FindStudent(string name) {
            return base.Channel.FindStudent(name);
        }
        
        public System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> FindStudentAsync(string name) {
            return base.Channel.FindStudentAsync(name);
        }
        
        public void DeleteStudent(int index) {
            base.Channel.DeleteStudent(index);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(int index) {
            return base.Channel.DeleteStudentAsync(index);
        }
        
        public UnitTestSOAP.ServiceReference1.Student EditStudent(UnitTestSOAP.ServiceReference1.Student studentA, UnitTestSOAP.ServiceReference1.Student studentB) {
            return base.Channel.EditStudent(studentA, studentB);
        }
        
        public System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student> EditStudentAsync(UnitTestSOAP.ServiceReference1.Student studentA, UnitTestSOAP.ServiceReference1.Student studentB) {
            return base.Channel.EditStudentAsync(studentA, studentB);
        }
        
        public UnitTestSOAP.ServiceReference1.Student[] GetAllStudent() {
            return base.Channel.GetAllStudent();
        }
        
        public System.Threading.Tasks.Task<UnitTestSOAP.ServiceReference1.Student[]> GetAllStudentAsync() {
            return base.Channel.GetAllStudentAsync();
        }
    }
}