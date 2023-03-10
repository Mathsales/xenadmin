//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XenOvf.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://schemas.dmtf.org/ovf/envelope/1")]
        public string cimEnvelopeURI {
            get {
                return ((string)(this["cimEnvelopeURI"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.microsoft.com/technet/virtualserver/downloads/vhdspec.mspx")]
        public string winFileFormatURI {
            get {
                return ((string)(this["winFileFormatURI"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XenServer P2V (Orela) Server")]
        public string p2vTemplate {
            get {
                return ((string)(this["p2vTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orela")]
        public string p2vGuestName {
            get {
                return ((string)(this["p2vGuestName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.0.0")]
        public string ovfversion {
            get {
                return ((string)(this["ovfversion"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0}")]
        public string FileURI {
            get {
                return ((string)(this["FileURI"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Virtual Hardware Requirements: {0} MB RAM; {1} CPU(s), {2} Disk(s), {3} Network(s" +
            ")")]
        public string vhsSettings {
            get {
                return ((string)(this["vhsSettings"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CPU;MEMORY;DISK")]
        public string OvfMimimalManifest {
            get {
                return ((string)(this["OvfMimimalManifest"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.9;1.0;1.0.0;1.0.0a;1.0.0.b;1.0.0c;1.0.0d;1.0.1;1.0.0e")]
        public string Versions {
            get {
                return ((string)(this["Versions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"ovf=http://schemas.dmtf.org/ovf/envelope/1, xs=http://www.w3.org/2001/XMLSchema,cim=http://schemas.dmtf.org/wbem/wscim/1/common,rasd=http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/CIM_ResourceAllocationSettingData,vssd=http://schemas.dmtf.org/wbem/wscim/1/cim-schema/2/CIM_VirtualSystemSettingData,xsi=http://www.w3.org/2001/XMLSchema-instance,xenovf=http://schemas.citrix.com/ovf/envelope/1,wsse=http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd,ds=http://www.w3.org/2000/09/xmldsig#,wsu=http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd,xenc=http://www.w3.org/2001/04/xmlenc#")]
        public string KnownNamespaces {
            get {
                return ((string)(this["KnownNamespaces"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true")]
        public string VerifySignatureOnly {
            get {
                return ((string)(this["VerifySignatureOnly"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pygrub")]
        public string xenPVBootloader {
            get {
                return ((string)(this["xenPVBootloader"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("graphical utf8")]
        public string xenKernelOptions {
            get {
                return ((string)(this["xenKernelOptions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BIOS order")]
        public string xenBootOptions {
            get {
                return ((string)(this["xenBootOptions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("order=dc;")]
        public string xenBootParams {
            get {
                return ((string)(this["xenBootParams"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nx=true;acpi=true;apic=true;pae=true;viridian=true;")]
        public string xenPVPlatformSetting {
            get {
                return ((string)(this["xenPVPlatformSetting"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nx=true;acpi=true;apic=true;pae=true;stdvga=0;")]
        public string xenPlatformSetting {
            get {
                return ((string)(this["xenPlatformSetting"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("hvm-3.0-unknown")]
        public string xenDefaultVirtualSystemType {
            get {
                return ((string)(this["xenDefaultVirtualSystemType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xenbr0")]
        public string xenDefaultNetwork {
            get {
                return ((string)(this["xenDefaultNetwork"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P2V Automatically created.")]
        public string xenP2VDiskName {
            get {
                return ((string)(this["xenP2VDiskName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vmwovf:http://www.vmware/schema/ovf")]
        public string vmwNameSpace {
            get {
                return ((string)(this["vmwNameSpace"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("network=")]
        public string xenNetworkKey {
            get {
                return ((string)(this["xenNetworkKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\DSP8023.xsd")]
        public string ovfEnvelopeSchemaLocation {
            get {
                return ((string)(this["ovfEnvelopeSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\DSP8027.xsd")]
        public string ovfEnvironmentSchemaLocation {
            get {
                return ((string)(this["ovfEnvironmentSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\xml.xsd")]
        public string xmlNamespaceSchemaLocation {
            get {
                return ((string)(this["xmlNamespaceSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\common.xsd")]
        public string cimCommonSchemaLocation {
            get {
                return ((string)(this["cimCommonSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\CIM_ResourceAllocationSettingData.xsd")]
        public string cimRASDSchemaLocation {
            get {
                return ((string)(this["cimRASDSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\CIM_VirtualSystemSettingData.xsd")]
        public string cimVSSDSchemaLocation {
            get {
                return ((string)(this["cimVSSDSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://schemas.dmtf.org/ovf/envelope/1/dsp8023.xsd")]
        public string dsp8023OnlineSchema {
            get {
                return ((string)(this["dsp8023OnlineSchema"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        public string useOnlineSchema {
            get {
                return ((string)(this["useOnlineSchema"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127")]
        public byte RequiredValidations {
            get {
                return ((byte)(this["RequiredValidations"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vmwovf")]
        public string vmwNamespacePrefix {
            get {
                return ((string)(this["vmwNamespacePrefix"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.vmware.com/schema/ovf/1/envelope")]
        public string vmwEnvelopeNamespace {
            get {
                return ((string)(this["vmwEnvelopeNamespace"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".vhd,.pvp,.vmdk,.mf,.cert,.xva,.ovf,.wim,.vdi,.sdi,.iso,.gz")]
        public string knownFileExtensions {
            get {
                return ((string)(this["knownFileExtensions"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".mf")]
        public string manifestFileExtension {
            get {
                return ((string)(this["manifestFileExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".cert")]
        public string certificateFileExtension {
            get {
                return ((string)(this["certificateFileExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SHA1")]
        public string securityAlgorithm {
            get {
                return ((string)(this["securityAlgorithm"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\secext-1.0.xsd")]
        public string wsseSchemaLocation {
            get {
                return ((string)(this["wsseSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]
        public string wsseOnlineSchema {
            get {
                return ((string)(this["wsseOnlineSchema"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\xenc-schema.xsd")]
        public string xencSchemaLocation {
            get {
                return ((string)(this["xencSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\wss-utility-1.0.xsd")]
        public string wsuSchemaLocation {
            get {
                return ((string)(this["wsuSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Schemas\\xmldsig-core-schema.xsd")]
        public string xmldsigSchemaLocation {
            get {
                return ((string)(this["xmldsigSchemaLocation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string encryptMicrosoftAlgorithmClass {
            get {
                return ((string)(this["encryptMicrosoftAlgorithmClass"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192")]
        public string encryptKeyLength {
            get {
                return ((string)(this["encryptKeyLength"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/2001/04/xmlenc#aes192-cbc")]
        public string encryptAlgorithmURI {
            get {
                return ((string)(this["encryptAlgorithmURI"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CitrixEncryptedKey")]
        public string encryptKeyName {
            get {
                return ((string)(this["encryptKeyName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.TripleDESCryptoServiceProvider")]
        public string tripledes_cbc {
            get {
                return ((string)(this["tripledes_cbc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string aes128_cbc {
            get {
                return ((string)(this["aes128_cbc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string aes256_cbc {
            get {
                return ((string)(this["aes256_cbc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string aes192_cbc {
            get {
                return ((string)(this["aes192_cbc"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RSACryptoServiceProvider")]
        public string rsa_1_5 {
            get {
                return ((string)(this["rsa_1_5"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RSACryptoServiceProvider")]
        public string rsa_oaep_mgf1p {
            get {
                return ((string)(this["rsa_oaep_mgf1p"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.TripleDESCryptoServiceProvider")]
        public string kw_tripledes {
            get {
                return ((string)(this["kw_tripledes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string kw_aes128 {
            get {
                return ((string)(this["kw_aes128"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string kw_aes256 {
            get {
                return ((string)(this["kw_aes256"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RijndaelManaged")]
        public string kw_aes192 {
            get {
                return ((string)(this["kw_aes192"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.SHA1CryptoServiceProvider")]
        public string sha1 {
            get {
                return ((string)(this["sha1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.SHA256CryptoServiceProvider")]
        public string sha256 {
            get {
                return ((string)(this["sha256"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.FromBase64Transform")]
        public string base64 {
            get {
                return ((string)(this["base64"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.SHA384CryptoServiceProvider")]
        public string sha384 {
            get {
                return ((string)(this["sha384"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.SHA512CryptoServiceProvider")]
        public string sha512 {
            get {
                return ((string)(this["sha512"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xen-3.0-unknown")]
        public string xenDefaultPVVirtualSystemType {
            get {
                return ((string)(this["xenDefaultPVVirtualSystemType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.osta.org/specs/pdf/udf260.pdf")]
        public string isoFileFormatURI {
            get {
                return ((string)(this["isoFileFormatURI"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-US")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("External Tools\\xenserver-linuxfixup-disk.iso")]
        public string xenLinuxFixUpDisk {
            get {
                return ((string)(this["xenLinuxFixUpDisk"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public double minPasswordStrength {
            get {
                return ((double)(this["minPasswordStrength"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("sr=")]
        public string xenSRKey {
            get {
                return ((string)(this["xenSRKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("device=")]
        public string xenDeviceKey {
            get {
                return ((string)(this["xenDeviceKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.DESCryptoServiceProvider")]
        public string des {
            get {
                return ((string)(this["des"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("System.Security.Cryptography.RC2CryptoServiceProvider\r\n")]
        public string rc2 {
            get {
                return ((string)(this["rc2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useGZip {
            get {
                return ((bool)(this["useGZip"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ovf:/disk/{0}")]
        public string hostresource {
            get {
                return ((string)(this["hostresource"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CIM_OperatingSystem.xml, CIM_ResourceAllocationSettingData.xml, CIM_VirtualSystem" +
            "SettingData.xml")]
        public string mofFiles {
            get {
                return ((string)(this["mofFiles"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>xen-3.0-unknown</string>
  <string>xen-3.0-x32</string>
  <string>xen-3.0-x86</string>
  <string>xen-3.0-x64</string>
  <string>hvm-3.0-unknown</string>
  <string>hvm-3.0-x32</string>
  <string>hvm-3.0-x86</string>
  <string>hvm-3.0-x64</string>
  <string>hvm-3.0-hvm</string>
  <string>301</string>
  <string>vmx-4</string>
  <string>vmx-04</string>
  <string>vmx-6</string>
  <string>vmx-06</string>
  <string>vmx-7</string>
  <string>vmx-07</string>
  <string>DMTF:xen:pv</string>
  <string>DMTF:xen:hvm</string>
  <string>virtualbox-2.2</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection knownVirtualSystemTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["knownVirtualSystemTypes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vmx-07")]
        public string vmwHardwareType {
            get {
                return ((string)(this["vmwHardwareType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.3.1")]
        public string securityVersion {
            get {
                return ((string)(this["securityVersion"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4096")]
        public int CompressBufferSize {
            get {
                return ((int)(this["CompressBufferSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".ovf")]
        public string ovfFileExtension {
            get {
                return ((string)(this["ovfFileExtension"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vdi=")]
        public string xenVDIKey {
            get {
                return ((string)(this["xenVDIKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vmw")]
        public string VMwareNamespacePrefix {
            get {
                return ((string)(this["VMwareNamespacePrefix"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.vmware/schema/ovf")]
        public string VMwareNamespace {
            get {
                return ((string)(this["VMwareNamespace"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Audit, Error, Warning")]
        public string LogLevel {
            get {
                return ((string)(this["LogLevel"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XenApplianceWizard.log")]
        public string LogFile {
            get {
                return ((string)(this["LogFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Audit, Console")]
        public string LogType {
            get {
                return ((string)(this["LogType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XenLocalOVF")]
        public string LogSource {
            get {
                return ((string)(this["LogSource"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ApplicationData")]
        public string LogPath {
            get {
                return ((string)(this["LogPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Plain//Stamp")]
        public string LogFormat {
            get {
                return ((string)(this["LogFormat"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("off//XenOvfLogFwd.dll,XenOvfLogFwd.Log4Net")]
        public string LogForwarding {
            get {
                return ((string)(this["LogForwarding"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[Citrix]\\[XenCenter]\\logs")]
        public string LogSubPath {
            get {
                return ((string)(this["LogSubPath"]));
            }
        }
    }
}
