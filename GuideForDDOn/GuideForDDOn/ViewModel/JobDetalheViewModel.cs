﻿using GuideForDDOn.Date;
using GuideForDDOn.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GuideForDDOn.ViewModel
{
    public class JobDetalheViewModel
    {
        public Job job { get; set; }
        public ContentPage Page { get; set; }
        public LabelsIdiomas Label { get {return LabelsIdiomasDAO.Label; } }

        public JobDetalheViewModel(Job job, ContentPage page)
        {
            Page = page;
            this.job = job;
        }
    }
}
