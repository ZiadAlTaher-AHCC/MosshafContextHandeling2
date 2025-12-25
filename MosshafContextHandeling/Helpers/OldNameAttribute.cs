namespace MosshafContextHandeling.Helpers
{
    [AttributeUsage(
    AttributeTargets.Property | AttributeTargets.Class,
    AllowMultiple = false,
    Inherited = true)]
    public sealed class OldNameAttribute : Attribute
    {
        public string OldName { get; }

        public OldNameAttribute(string oldName)
        {
            OldName = oldName;
        }
    }
}
