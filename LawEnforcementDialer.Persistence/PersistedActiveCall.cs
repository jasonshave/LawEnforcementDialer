﻿namespace LawEnforcementDialer.Persistence;

public class PersistedActiveCall
{
    public string Id { get; set; }

    public string Source { get; set; }

    public string Target { get; set; }

    public List<string> Participants { get; set; }

    public string CorrelationId { get; }
}