﻿// This file lists existing suppressions
// Feel free to delete lines when you fix the underlying issue.
// You should never add to this file; if you must suppress an FxCop warning, put the suppression inline.
// If you absolutely MUST add to this file, you can run 'oacr fxcop <project> /target <assembly>'
// where <project> is HealthVault or HealthVault_SDK and assembly is the dll you're building, including extension.
// This will launch the fxcop gui. Click Analyze, then rightclick the error and select Copy As -> Module level suppression. Paste here.

using System.Diagnostics.CodeAnalysis;

[module: SuppressMessage("Microsoft.Security.Cryptography", "CA5357:RijndaelCannotBeUsed", Scope = "member", Target = "Microsoft.Health.Authentication.CryptoConfiguration.#CreateSymmetricAlgorithm(System.String,System.Byte[])")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#ConstructVersionString()")]
[module: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Microsoft.Health.BlobStream.#Dispose()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#StartPostRequest()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#WaitForCompletion()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#RequestCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#ResponseCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "Microsoft.Health.HealthRecordAuthorizationRequiredException.#.ctor()")]
[module: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "Microsoft.Health.HealthServiceRequestCancelledException.#.ctor()")]
[module: SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Microsoft.Health.AuthorizedRecordState")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Health.BlobStore.#System.Collections.IEnumerable.GetEnumerator()")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Health.BlobStore.#System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,Microsoft.Health.Blob>>.CopyTo(System.Collections.Generic.KeyValuePair`2<System.String,Microsoft.Health.Blob>[],System.Int32)")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Health.BlobStore.#System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,Microsoft.Health.Blob>>.GetEnumerator()")]
[module: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Microsoft.Health.BlobStore.#System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,Microsoft.Health.Blob>>.get_IsReadOnly()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Health.ItemTypeManager.#RegisterExternalTypeHandlers()")]
[module: SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Scope = "member", Target = "Microsoft.Health.CultureSpecificDictionary`1.#DefaultLanguage")]
[module: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "Microsoft.Health.HealthRecordAuthorizationNotPossible.#.ctor()")]
[module: SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", Scope = "member", Target = "Microsoft.Health.PersonInfo.#ApplicationSettingsDocument", MessageId = "System.Xml.XmlNode")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Health.OpenQuery.#NewQuery(Microsoft.Health.Web.OfflineWebApplicationConnection,Microsoft.Health.HealthRecordSearcher,System.Int32,System.String,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Microsoft.Health.OpenQuery.#Invoke(System.Int32,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Health.OpenQuery.#NewQuery(Microsoft.Health.AuthenticatedConnection,Microsoft.Health.HealthRecordSearcher,System.Int32,System.String,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Health.OpenQuery.#Remove(Microsoft.Health.AuthenticatedConnection)")]
[module: SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Microsoft.Health.OpenQuery.#Remove(Microsoft.Health.AuthenticatedConnection,System.Guid)")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Microsoft.Health.HealthServiceRequest+WebResponseStreamHandler")]
[module: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "member", Target = "Microsoft.Health.HealthRecordReauthorizationRequired.#.ctor()")]
[module: SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue", Scope = "type", Target = "Microsoft.Health.ApplicationOptions")]
[module: SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", Scope = "member", Target = "Microsoft.Health.PlatformPrimitives.HealthVaultPlatformVocabulary.#SearchVocabulary(Microsoft.Health.HealthServiceConnection,Microsoft.Health.VocabularyKey,System.String,Microsoft.Health.VocabularySearchType,System.Nullable`1<System.Int32>,Microsoft.Health.VocabularyItemCollection&,System.Collections.ObjectModel.ReadOnlyCollection`1<Microsoft.Health.VocabularyKey>&)", MessageId = "5#")]
[module: SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", Scope = "member", Target = "Microsoft.Health.PlatformPrimitives.HealthVaultPlatformVocabulary.#SearchVocabulary(Microsoft.Health.HealthServiceConnection,Microsoft.Health.VocabularyKey,System.String,Microsoft.Health.VocabularySearchType,System.Nullable`1<System.Int32>,Microsoft.Health.VocabularyItemCollection&,System.Collections.ObjectModel.ReadOnlyCollection`1<Microsoft.Health.VocabularyKey>&)", MessageId = "6#")]
[module: SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Microsoft.Health.Web.OfflineWebApplicationConnection.#.ctor(System.Guid,System.String,System.Guid)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.ItemTypes.Csv.OtherItemDataCsv.#SetOtherData(System.Collections.Generic.IList`1<Microsoft.Health.ItemTypes.Csv.OtherItemDataCsvItem>)", MessageId = "System.Double.ToString")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.ItemTypes.Csv.OtherItemDataCsv.#GetAsDouble()", MessageId = "System.Double.Parse(System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#CreateInputDecompressionStream(System.IO.Stream,System.String,System.Boolean)", MessageId = "System.String.ToLower")]
[module: SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#CreateOutputCompressionStream(System.IO.Stream,System.String,System.Boolean)", MessageId = "System.String.ToLower")]
[module: SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#set_ResponseCompressionMethods(System.String)", MessageId = "System.String.ToLower")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#GetHeaderSection(System.String,System.String,System.Byte[]&,System.Int32&)", MessageId = "System.Int32.ToString")]
[module: SuppressMessage("Microsoft.Globalization", "CA1309:UseOrdinalStringComparison", Scope = "member", Target = "Microsoft.Health.Vocabulary.#.ctor()", MessageId = "System.Collections.Generic.Dictionary`2<System.String,Microsoft.Health.VocabularyItem>.#ctor(System.Collections.Generic.IEqualityComparer`1<System.String>)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.ApplicationInfo.#GetRequestParameters(System.Guid)", MessageId = "System.Int32.ToString")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.ItemTypeDataColumn.#ToString()", MessageId = "System.Int32.ToString")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Health.HealthServiceConnection.#set_ResponseCompressionMethods(System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1309:UseOrdinalStringComparison", Scope = "member", Target = "Microsoft.Health.HealthServiceConnection.#.ctor(System.Guid,System.Uri)", MessageId = "System.String.EndsWith(System.String,System.StringComparison)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.HealthRecordItem.#AddCoreSectionValues(System.Xml.XPath.XPathNavigator)", MessageId = "System.Convert.ToInt64(System.String)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "Microsoft.Health.HealthRecordItem.#AddCorePutThingsRequestParameters(System.Xml.XmlWriter,System.Boolean,Microsoft.Health.HealthRecordItemSections)", MessageId = "System.UInt32.ToString")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Health.HealthRecordView.#AddBlobFormatXml(System.Xml.XmlWriter)")]
[module: SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Health.PlatformPrimitives.HealthVaultPlatformInformation.#WriteSectionSpecs(System.Xml.XmlWriter,Microsoft.Health.HealthRecordItemTypeSections)")]
[module: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Microsoft.Health.ApplicationInfo.#GetRequestParameters(System.Guid)")]
[module: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Microsoft.Health.HealthRecordFilter.#CreateFromXml(System.Xml.XPath.XPathNavigator)")]
[module: SuppressMessage("Microsoft.MSInternal", "CA900:AptcaAssembliesShouldBeReviewed")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "type", Target = "Microsoft.Health.HealthServiceRequestCancelledException", MessageId = "Cancelled")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.AuthorizationRule.#CreateFromXml(System.Xml.XPath.XPathNavigator)", MessageId = "Nav")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "member", Target = "Microsoft.Health.AuthorizationRule.#DisplayFlags", MessageId = "Flags")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "member", Target = "Microsoft.Health.AuthorizationRule.#.ctor(System.String,System.String,Microsoft.Health.HealthRecordItemPermissions,System.Collections.Generic.IList`1<Microsoft.Health.AuthorizationSetDefinition>,System.Collections.Generic.IList`1<Microsoft.Health.AuthorizationSetDefinition>,System.Boolean,Microsoft.Health.AuthorizationRuleDisplayFlags)", MessageId = "Flags")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.AuthenticatedConnection.#LogOn(System.String,System.Boolean,System.Threading.ManualResetEvent)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.AuthenticatedConnection.#LogOn(System.String,System.Boolean)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.AuthenticatedConnection.#LogOn(System.String,System.Boolean,System.Boolean,System.Threading.ManualResetEvent,System.Guid,System.Uri,System.Uri)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.AuthenticatedConnection.#LogOn(System.String,System.Boolean,System.Threading.ManualResetEvent,System.Guid,System.Uri,System.Uri)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "type", Target = "Microsoft.Health.HealthRecordItemFlags", MessageId = "Flags")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.HealthRecordItemSignature.#RsaSha1W3cAlgorithmName", MessageId = "c")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Health.BlobStore")]
[module: SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", Scope = "member", Target = "Microsoft.Health.BlobStore.#Add(System.String,Microsoft.Health.Blob)", MessageId = "1#")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Microsoft.Health.BlobStore.#WriteInline(System.String,System.String,System.Byte[])", MessageId = "bytes")]
[module: SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", Scope = "member", Target = "Microsoft.Health.BlobStore.#Item[System.String]", MessageId = "0#")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Health.Vocabulary")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.ApplicationInfo.#PersistentTokenTtlInSeconds", MessageId = "Ttl")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.ApplicationInfo.#DtcSuccessMessage", MessageId = "Dtc")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "member", Target = "Microsoft.Health.HealthServiceStatusCode.#PersonalFlagUnsupported", MessageId = "Flag")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "member", Target = "Microsoft.Health.HealthServiceStatusCode.#CantConvertUnits", MessageId = "Cant")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.HealthServiceStatusCode.#ThingTypeNotDeletable", MessageId = "Deletable")]
[module: SuppressMessage("Microsoft.Naming", "CA1717:OnlyFlagsEnumsShouldHavePluralNames", Scope = "type", Target = "Microsoft.Health.HealthVaultMethods")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "type", Target = "Microsoft.Health.IMarshallable", MessageId = "Marshallable")]
[module: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Microsoft.Health.VocabularyItemCollection")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Health.VocabularyItemCollection")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "member", Target = "Microsoft.Health.HealthRecordItem.#Flags", MessageId = "Flags")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Health.HealthRecordAuthorizationNotPossible")]
[module: SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Microsoft.Health.HealthRecordItemTypePermission")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Microsoft.Health.Blob.#WriteInline(System.Byte[])", MessageId = "bytes")]
[module: SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", Scope = "type", Target = "Microsoft.Health.AuthorizationRuleDisplayFlags", MessageId = "Flags")]
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Microsoft.Health.HealthRecordReauthorizationRequired")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Microsoft.Health.ApplicationConnection.#SearchVocabulary(Microsoft.Health.VocabularyKey,System.String,Microsoft.Health.VocabularySearchType,System.Nullable`1<System.Int32>)", MessageId = "string")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Microsoft.Health.ApplicationConnection.#SearchVocabularyKeys(System.String,Microsoft.Health.VocabularySearchType,System.Nullable`1<System.Int32>)", MessageId = "string")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "type", Target = "Microsoft.Health.ApplicationProvisioning.Provisioner", MessageId = "Provisioner")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.ApplicationTokenCreationInfo.#.ctor(System.Guid,System.Boolean)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.ApplicationTokenCreationInfo.#.ctor(System.Guid,System.Boolean,System.String)", MessageId = "Mra")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.ApplicationTokenCreationInfo.#IsMRA", MessageId = "MRA")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.ShellRedirectParameters.#IsMultiRecordApplication", MessageId = "Multi")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Scope = "member", Target = "Microsoft.Health.HealthApplicationConfiguration.#MultiInstanceAware", MessageId = "Multi")]
[module: SuppressMessage("Microsoft.Performance", "CA1824:MarkAssembliesWithNeutralResourcesLanguage")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Health.Web.Authentication.WebApplicationCredential.#set_TokenIssuedRefreshCounter(System.Int64)")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#.ctor(System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#.ctor(System.Byte[],System.Int32)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Health.HealthRecordItemSignature.#GetCertificateFailureInfo(System.Security.Cryptography.X509Certificates.X509Certificate2)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Health.BlobStore.#Add(Microsoft.Health.Blob)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Health.BlobStore.#MapNullKey(System.String)")]
[module: SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsDateTime(System.Xml.XPath.XPathNavigator,System.String,System.DateTime)")]
[module: SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsEnum`1(System.Xml.XPath.XPathNavigator,System.String,!!0)")]
[module: SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsBoolean(System.Xml.XPath.XPathNavigator,System.String,System.Boolean)")]
[module: SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsLong(System.Xml.XPath.XPathNavigator,System.String,System.Nullable`1<System.Int64>)")]
[module: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Health.HealthRecordItemCollection.#GetGroupXPathExpression(System.Xml.XPath.XPathNavigator)")]
[module: SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Microsoft.Health.ServiceInfo.#Assemblies")]
[module: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", Scope = "member", Target = "Microsoft.Health.Certificate.ApplicationCertificate.#CreateCert(System.Guid,System.Int16)", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle")]
[module: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "Microsoft.Health.Certificate.CryptoApiBlob.#Dispose()")]
[module: SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Scope = "member", Target = "Microsoft.Health.Certificate.CryptoApiBlob.#Dispose(System.Boolean)")]
[module: SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#Dispose(System.Boolean)", MessageId = "_eventAsyncReady")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Microsoft.Health.BlobStore.#Add(Microsoft.Health.Blob)", MessageId = "blob")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Microsoft.Health.Vocabulary")]
[module: SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsDateTime(System.Xml.XPath.XPathNavigator,System.String,System.DateTime)", MessageId = "System.DateTime.TryParse(System.String,System.IFormatProvider,System.Globalization.DateTimeStyles,System.DateTime@)")]
[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "Microsoft.Health.XPathHelper.#ParseAttributeAsLong(System.Xml.XPath.XPathNavigator,System.String,System.Nullable`1<System.Int64>)", MessageId = "defaultValue")]
[module: SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible", Scope = "member", Target = "Microsoft.Health.ApplicationInfo.#ExpectedApplicationAttributes")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.HealthRecordItemTypeDefinition.#Versions")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.HealthRecordItemTypeDefinition.#TransformSource")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.HealthRecordItemTypeDefinition.#ColumnDefinitions")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.HealthRecordItemTypeDefinition.#SupportedTransformNames")]
[module: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Microsoft.Health.CultureSpecificDictionary`1")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.VocabularyItem.#Vocabulary")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.PersonInfo.#AuthorizedRecords")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.ServiceInfo.#Methods")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.ServiceInfo.#IncludedSchemaUrls")]
[module: SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Microsoft.Health.ServiceInfo.#ConfigurationValues")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.Credential.#set_SharedSecret(Microsoft.Health.Authentication.CryptoHash)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.CryptoHash.#set_AlgorithmName(System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.CryptoHash.#CreateInfoHash(System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.CryptoHash.#set_HashAlgorithm(System.Security.Cryptography.HashAlgorithm)")]
[module: SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Scope = "member", Target = "Microsoft.Health.Authentication.CryptoHash.#ComputeHash(System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Microsoft.Health.HealthApplicationConfiguration.#get_HealthVaultTypeSchemaUrl()")]
[module: SuppressMessage("Microsoft.Usage", "CA2234:PassSystemUriObjectsInsteadOfStrings", Scope = "member", Target = "Microsoft.Health.Events.HealthRecordItemChangedEventArgs.#GetItems(System.Guid,System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.SDKHelper.#SafeLoadXml(System.Xml.XmlDocument,System.String)")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.HealthVaultMethods.#GetMeaningfulUseVDTReport", MessageId = "VDT")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#GetHeaderSection(System.String,System.String,System.Byte[]&,System.Int32&)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#BuildRequestXml(System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#GetInfoSection(System.String&,System.Byte[]&,System.Int32&)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthServiceRequest.#HandleResponseStreamResult(System.IO.Stream)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#ResponseCallback(System.IAsyncResult)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.EasyWebRequest.#StartGetRequest()")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.TransformResponseHandler.#HandleResponse(System.IO.Stream,System.Net.WebHeaderCollection)")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.HealthVaultPlatform.#GetMeaningfulUseVDTReport(Microsoft.Health.HealthServiceConnection,Microsoft.Health.DateRange)", MessageId = "VDT")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.HealthVaultPlatform.#GetMeaningfulUseTimelyAccessDOPUDocumentReport(Microsoft.Health.HealthServiceConnection,Microsoft.Health.DateRange)", MessageId = "DOPU")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthRecordExporter.#ExportItems()")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.HealthRecordExporter.#TransformItemXml(System.String)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.MailRecipient.#ToString()")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.ApplicationConnection.#GetMeaningfulUseTimelyAccessDOPUDocumentReport(Microsoft.Health.DateRange)", MessageId = "DOPU")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.ApplicationConnection.#GetMeaningfulUseVDTReport(Microsoft.Health.DateRange)", MessageId = "VDT")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.Blob.#ReadAsString(System.Text.Encoding)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.Blob.#ReadAllBytes()")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "member", Target = "Microsoft.Health.BlobHashAlgorithm.#SHA256Block", MessageId = "SHA")]
[module: SuppressMessage("Microsoft.Usage", "CA2215:Dispose methods should call base class dispose", Scope = "member", Target = "Microsoft.Health.BlobStream.#Dispose(System.Boolean)")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.BlobStream.#WriteChunk(System.Int32,System.Boolean)")]
[module: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Scope = "type", Target = "Microsoft.Health.MeaningfulUse.DOPUDocumentReceipt", MessageId = "DOPU")]
[module: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Microsoft.Health.PlatformPrimitives.HealthVaultPlatformPatientConnect.#GetCreateConnectRequestParameters(System.String,System.String,System.String,System.Uri,System.String)")]