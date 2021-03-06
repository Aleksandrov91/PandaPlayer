﻿using Panda_Player.Models.Manage.Admin;
using Panda_Player.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panda_Player.Models.PandaPlayer
{
    public class SongViewModel : BaseViewModel
    {
        public SongViewModel()
        {
            
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Artist *")]
        public string Artist { get; set; }

        [Required]
        [Display(Name = "Title *")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Song Path *")]
        public string SongPath { get; set; }

        public string UploaderId { get; set; }

        [Required]
        public DateTime UploadDate { get; set; }

        [Required]
        [Display(Name = "Genre *")]
        public ICollection<Genre> Genre { get; set; }

        [Required]
        [Display(Name = "Genre *")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "File *")]
        public HttpPostedFileBase File { get; set; }

        public string Tags { get; set; }
    }
}