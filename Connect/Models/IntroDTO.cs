﻿using System.ComponentModel.DataAnnotations;

namespace Connect.Models {
    [MetadataType(typeof(IntroDTO))]
    public partial class SelfIntro {

    }

    public class IntroDTO {
        public IntroDTO() {

        }

        public IntroDTO(SelfIntro intro) {
            IntroId = intro.IntroId;
            Intro = intro.Intro;
            UserId = intro.UserId;
        }

        public long IntroId { get; set; }
        [Display(Name = "Intro")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Intro required")]
        [RegularExpression(@"^[0-9 a-z A-Z\.|@_-]+$", ErrorMessage = "invalid character(s) detected.")]
        public string Intro { get; set; }
        public long? UserId { get; set; }
    }
}