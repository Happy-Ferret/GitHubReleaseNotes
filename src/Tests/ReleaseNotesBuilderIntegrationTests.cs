﻿namespace ReleaseNotesCompiler.Tests
{
    using System.Diagnostics;
    using NUnit.Framework;
    using ReleaseNotesCompiler;

    [TestFixture]
    public class ReleaseNotesBuilderIntegrationTests
    {
        [Test]
        [Explicit]
        public async void SingleMilestone()
        {
            var gitHubClient = ClientBuilder.Build();

            var releaseNotesBuilder = new ReleaseNotesBuilder(new DefaultGitHubClient(gitHubClient, "Particular", "NServiceBus"), "Particular", "NServiceBus", "5.1.0");
            var result = await releaseNotesBuilder.BuildReleaseNotes();
            Debug.WriteLine(result);
            ClipBoardHelper.SetClipboard(result);
        }

        [Test]
        [Explicit]
        public async void SingleMilestone3()
        {
            var gitHubClient = ClientBuilder.Build();

            var releaseNotesBuilder = new ReleaseNotesBuilder(new DefaultGitHubClient(gitHubClient, "Particular", "ServiceControl"), "Particular", "ServiceControl", "1.0.0-Beta4");
            var result = await releaseNotesBuilder.BuildReleaseNotes();
            Debug.WriteLine(result);
            ClipBoardHelper.SetClipboard(result);
        }

        [Test]
        [Explicit]
        public void OctokitTests()
        {
            ClientBuilder.Build();
        }
    }
}
