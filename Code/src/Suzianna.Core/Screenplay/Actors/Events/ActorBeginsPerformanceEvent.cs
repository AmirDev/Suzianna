﻿using Suzianna.Core.Events;

namespace Suzianna.Core.Screenplay.Actors.Events
{
    public class ActorBeginsPerformanceEvent : IEvent
    {
        public ActorBeginsPerformanceEvent(string actorName)
        {
            ActorName = actorName;
        }

        public string ActorName { get; private set; }
    }
}