using System;

using RomeUtilities = R5T.Rome.Utilities;


namespace ΩMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.DeployScript();
        }

        /// <summary>
        /// Deploys (copies compilation output directory binary and other files) to a file-system site specified by an R5T.Antium.Base.IDeploymentDestinationFileSystemSiteProvider.
        /// The implementation of which in R5T.Antium.Default uses an R5T.Suebia.Base.ISecretsFilePathProvider and an R5T.Antium.Default.IDeploymentDestinationSecretsFileNameProvider to get details of the deployment file-system site.
        /// The IDeploymentDestinationSecretsFileNameProvider implementation in R5T.Antium.Default uses a file-name constructor parameter, and is meant to be instantiated in this maintenance console project, and added to the service provider configured by this maintenance console project as a singleton.
        /// </summary>
        private static void DeployScript()
        {
            var localDeploymentSecretsFileName = "R5T.Rome.HelloWorld-LocalDeployment.json";
            var entryPointProjectName = "R5T.Rome.HelloWorld";

            RomeUtilities.DeployLocal(localDeploymentSecretsFileName, entryPointProjectName);
        }
    }
}
