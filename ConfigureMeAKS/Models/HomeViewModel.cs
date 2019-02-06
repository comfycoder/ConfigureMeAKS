namespace ConfigureMeAKS.Models
{
    public class HomeViewModel
    {
        public string EnvironmentName { get; set; }
        public string HostName { get; set; }
        public string MySetting { get; set; }
        public string MySecret { get; set; }
        public string MySecretFile = "/kvmnt/MySecret";
    }
}
