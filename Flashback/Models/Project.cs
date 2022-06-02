﻿using Helpers.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Collections;

namespace Flashback.Models
{
    [DataContract]
    public class Project : ViewModelBase
    {
        [IgnoreDataMember]
        private Track _track = new Track();
        /// <summary>
        /// Background music object.
        /// </summary>
        [DataMember]
        public Track Track
        {
            get
            {
                return _track;
            }
            set
            {
                _track = value;
                RaisePropertyChanged(nameof(Track));
            }
        }

        [IgnoreDataMember]
        private ObservableCollection<Clip> _clips = new ObservableCollection<Clip>();
        /// <summary>
        /// Keeps all video clips.
        /// </summary>
        [DataMember]
        public ObservableCollection<Clip> Clips
        {
            get
            {
                return _clips;
            }
            set
            {
                _clips = value;
                RaisePropertyChanged(nameof(Clips));
            }
        }

        [IgnoreDataMember]
        private Clip _selectedClip = null;
        /// <summary>
        /// Determines clip selected for editing
        /// </summary>
        [IgnoreDataMember]
        public Clip SelectedClip
        {
            get
            {
                return _selectedClip;
            }
            set
            {
                _selectedClip = value;
                RaisePropertyChanged(nameof(SelectedClip));
            }
        }

        [IgnoreDataMember]
        private int _videoQuality = 0;
        /// <summary>
        /// Video quality type.
        /// </summary>
        [DataMember]
        public int VideoQuality
        {
            get
            {
                return _videoQuality;
            }
            set
            {
                _videoQuality = value;
                RaisePropertyChanged(nameof(VideoQuality));
            }
        }

        public Project() { }

        /// <summary>
        /// Restores object.
        /// </summary>
        /// <returns></returns>
        public async Task RestoreAsync()
        {
            // Restore track
            await Track.RestoreAsync();

            // Restore clips
            foreach (var clip in Clips)
            {
                await clip.RestoreAsync();
            }
        }
    }
}
