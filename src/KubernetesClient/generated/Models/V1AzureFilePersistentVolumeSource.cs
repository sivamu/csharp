// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// AzureFile represents an Azure File Service mount on the host and bind mount to
        /// the pod.
    /// </summary>
    public partial class V1AzureFilePersistentVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1AzureFilePersistentVolumeSource class.
        /// </summary>
        public V1AzureFilePersistentVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1AzureFilePersistentVolumeSource class.
        /// </summary>
        /// <param name="secretName">
        /// the name of secret that contains Azure Storage Account Name and Key
        /// </param>
        /// <param name="shareName">
        /// Share Name
        /// </param>
        /// <param name="readOnlyProperty">
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.
        /// </param>
        /// <param name="secretNamespace">
        /// the namespace of the secret that contains Azure Storage Account Name and Key
        /// default is the same as the Pod
        /// </param>
        public V1AzureFilePersistentVolumeSource(string secretName, string shareName, bool? readOnlyProperty = null, string secretNamespace = null)
        {
            ReadOnlyProperty = readOnlyProperty;
            SecretName = secretName;
            SecretNamespace = secretNamespace;
            ShareName = shareName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// the name of secret that contains Azure Storage Account Name and Key
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }

        /// <summary>
        /// the namespace of the secret that contains Azure Storage Account Name and Key
        /// default is the same as the Pod
        /// </summary>
        [JsonProperty(PropertyName = "secretNamespace")]
        public string SecretNamespace { get; set; }

        /// <summary>
        /// Share Name
        /// </summary>
        [JsonProperty(PropertyName = "shareName")]
        public string ShareName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
