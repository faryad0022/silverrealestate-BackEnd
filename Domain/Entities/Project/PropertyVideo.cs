﻿namespace Domain.Entities.Project
{
    public class PropertyVideo : BaseEntity
    {
        public string YoutubeLink { get; set; }
        public string AparatLink { get; set; }
        public long PropertyId { get; set; }
        public Property ProPerty { get; set; }
    }
}
