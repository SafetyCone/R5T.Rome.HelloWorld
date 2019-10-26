using System;

using RomeUtilities = R5T.Rome.Utilities;


namespace ΩMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.LocalDeployScript();
            //Program.RemoteDeployScript();
            Program.AddMissingDependencies();
        }

        private static void AddMissingDependencies()
        {
            RomeUtilities.AddMissingDependencies();
        }

        /// <summary>
        /// Deploys (copies compilation output directory binary and other files) to a remote file-system site.
        /// </summary>
        private static void RemoteDeployScript()
        {
            var remoteDeploymentSecretsFileName = "R5T.Rome.HelloWorld-RemoteDeployment.json";
            var entryPointProjectName = "R5T.Rome.HelloWorld";

            RomeUtilities.DeployRemote(remoteDeploymentSecretsFileName, entryPointProjectName);
        }

        /// <summary>
        /// Deploys (copies compilation output directory binary and other files) to a local file-system site specified by an R5T.Antium.Base.IDeploymentDestinationFileSystemSiteProvider.
        /// The implementation of which in R5T.Antium.Default uses an R5T.Suebia.Base.ISecretsFilePathProvider and an R5T.Antium.Default.IDeploymentDestinationSecretsFileNameProvider to get details of the deployment file-system site.
        /// The IDeploymentDestinationSecretsFileNameProvider implementation in R5T.Antium.Default uses a file-name constructor parameter, and is meant to be instantiated in this maintenance console project, and added to the service provider configured by this maintenance console project as a singleton.
        /// </summary>
        private static void LocalDeployScript()
        {
            var localDeploymentSecretsFileName = "R5T.Rome.HelloWorld-LocalDeployment.json";
            var entryPointProjectName = "R5T.Rome.HelloWorld";

            RomeUtilities.DeployLocal(localDeploymentSecretsFileName, entryPointProjectName);
        }
    }
}
