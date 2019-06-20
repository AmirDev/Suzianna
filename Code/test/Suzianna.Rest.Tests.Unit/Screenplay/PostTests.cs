﻿using System.Linq;
using System.Net.Http;
using NFluent;
using Suzianna.Core.Screenplay.Actors;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Tests.Unit.TestConstants;
using Suzianna.Rest.Tests.Unit.TestUtils;
using Xunit;

namespace Suzianna.Rest.Tests.Unit.Screenplay
{
    public class PostTests : HttpInteractionWithContentTests
    {
        private Actor actor;
        public PostTests()
        {
            actor = ActorFactory.CreateSomeActorWithApiCallAbility(Sender);
        }
        protected override HttpMethod GetHttpMethod() => HttpMethod.Post;
        protected override HttpInteraction GetHttpInteraction(string resource)
        {
            return Post.DataAsJson(ContentFactory.SomeContent()).To(resource);
        }

        protected override HttpInteraction GetHttpInteractionWithJsonContent(object content)
        {
            return Post.DataAsJson(content).To(Urls.UsersApi);
        }
        protected override HttpInteraction GetHttpInteractionWithXmlContent(object content)
        {
            return Post.DataAsXml(content).To(Urls.UsersApi);
        }
    }
}
