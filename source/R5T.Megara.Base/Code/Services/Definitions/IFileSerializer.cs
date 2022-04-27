using System;

using R5T.T0064;


namespace R5T.Megara
{
    /// <summary>
    /// De/serializes an object to/from a file.
    /// </summary>
    /// <remarks>
    /// The details of what file format (BinaryFormatter, custom binary format, XML, text, etc.) are left unspecified.
    ///
    /// Note to implementers:
    /// * Upon writing, note that the optional overwrite argument default value is true.
    /// </remarks>
    [ServiceDefinitionMarker]
    public interface IFileSerializer<T> : IServiceDefinition
    {
        /// <summary>
        /// Deserializes an object from a file.
        /// </summary>
        /// <param name="filePath">The rooted file path to use.</param>
        T Deserialize(string filePath);

        /// <summary>
        /// Serializes an object to a file.
        /// </summary>
        /// <param name="filePath">The rooted file path to use.</param>
        void Serialize(string filePath, T value, bool overwrite = true);
    }
}
