using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsMediaRedirect.OldMetadata {
	[XmlRoot(ElementName = "track")]
	public class Track {
        private string wMContentID;
        private string trackRequestID;
        private string trackTitle;
        private string uniqueFileID;
        private string trackNumber;
        private string trackPerformer;
        private string trackComposer;
        private string trackConductor;
        private string period;
        private string explicitLyrics;

        [XmlElement(ElementName = "WMContentID")]
        public string WMContentID {
            get { return wMContentID; }
            set { wMContentID = value; }
        }

        [XmlElement(ElementName = "trackRequestID")]
        public string TrackRequestID {
            get { return trackRequestID; }
            set { trackRequestID = value; }
        }

        [XmlElement(ElementName = "trackTitle")]
        public string TrackTitle {
            get { return trackTitle; }
            set { trackTitle = value; }
        }

        [XmlElement(ElementName = "uniqueFileID")]
        public string UniqueFileID {
            get { return uniqueFileID; }
            set { uniqueFileID = value; }
        }

        [XmlElement(ElementName = "trackNumber")]
        public string TrackNumber {
            get { return trackNumber; }
            set { trackNumber = value; }
        }

        [XmlElement(ElementName = "trackPerformer")]
        public string TrackPerformer {
            get { return trackPerformer; }
            set { trackPerformer = value; }
        }

        [XmlElement(ElementName = "trackComposer")]
        public string TrackComposer {
            get { return trackComposer; }
            set { trackComposer = value; }
        }

        [XmlElement(ElementName = "trackConductor")]
        public string TrackConductor {
            get { return trackConductor; }
            set { trackConductor = value; }
        }

        [XmlElement(ElementName = "period")]
        public string Period {
            get { return period; }
            set { period = value; }
        }

        [XmlElement(ElementName = "explicitLyrics")]
        public string ExplicitLyrics {
            get { return explicitLyrics; }
            set { explicitLyrics = value; }
        }
    }

	[XmlRoot(ElementName = "MDR-CD")]
	public class MDRCD {
        private string version;
        private string mdqRequestID;
        private string wMCollectionID;
        private string wMCollectionGroupID;
        private string uniqueFileID;
        private string albumTitle;
        private string albumArtist;
        private string releaseDate;
        private string label;
        private string genre;
        private string providerStyle;
        private string publisherRating;
        private string buyParams;
        private string largeCoverParams;
        private string smallCoverParams;
        private string moreInfoParams;
        private string dataProvider;
        private string dataProviderParams;
        private string dataProviderLogo;
        private string needIDs;
        private List<Track> track;

        [XmlElement(ElementName = "version")]
        public string Version {
            get { return version; }
            set { version = value; }
        }

        [XmlElement(ElementName = "mdqRequestID")]
        public string MdqRequestID {
            get { return mdqRequestID; }
            set { mdqRequestID = value; }
        }

        [XmlElement(ElementName = "WMCollectionID")]
        public string WMCollectionID {
            get { return wMCollectionID; }
            set { wMCollectionID = value; }
        }

        [XmlElement(ElementName = "WMCollectionGroupID")]
        public string WMCollectionGroupID {
            get { return wMCollectionGroupID; }
            set { wMCollectionGroupID = value; }
        }

        [XmlElement(ElementName = "uniqueFileID")]
        public string UniqueFileID {
            get { return uniqueFileID; }
            set { uniqueFileID = value; }
        }

        [XmlElement(ElementName = "albumTitle")]
        public string AlbumTitle {
            get { return albumTitle; }
            set { albumTitle = value; }
        }

        [XmlElement(ElementName = "albumArtist")]
        public string AlbumArtist {
            get { return albumArtist; }
            set { albumArtist = value; }
        }

        [XmlElement(ElementName = "releaseDate")]
        public string ReleaseDate {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        [XmlElement(ElementName = "label")]
        public string Label {
            get { return label; }
            set { label = value; }
        }

        [XmlElement(ElementName = "genre")]
        public string Genre {
            get { return genre; }
            set { genre = value; }
        }

        [XmlElement(ElementName = "providerStyle")]
        public string ProviderStyle {
            get { return providerStyle; }
            set { providerStyle = value; }
        }

        [XmlElement(ElementName = "publisherRating")]
        public string PublisherRating {
            get { return publisherRating; }
            set { publisherRating = value; }
        }

        [XmlElement(ElementName = "buyParams")]
        public string BuyParams {
            get { return buyParams; }
            set { buyParams = value; }
        }

        [XmlElement(ElementName = "largeCoverParams")]
        public string LargeCoverParams {
            get { return largeCoverParams; }
            set { largeCoverParams = value; }
        }

        [XmlElement(ElementName = "smallCoverParams")]
        public string SmallCoverParams {
            get { return smallCoverParams; }
            set { smallCoverParams = value; }
        }

        [XmlElement(ElementName = "moreInfoParams")]
        public string MoreInfoParams {
            get { return moreInfoParams; }
            set { moreInfoParams = value; }
        }

        [XmlElement(ElementName = "dataProvider")]
        public string DataProvider {
            get { return dataProvider; }
            set { dataProvider = value; }
        }

        [XmlElement(ElementName = "dataProviderParams")]
        public string DataProviderParams {
            get { return dataProviderParams; }
            set { dataProviderParams = value; }
        }

        [XmlElement(ElementName = "dataProviderLogo")]
        public string DataProviderLogo {
            get { return dataProviderLogo; }
            set { dataProviderLogo = value; }
        }

        [XmlElement(ElementName = "needIDs")]
        public string NeedIDs {
            get { return needIDs; }
            set { needIDs = value; }
        }

        [XmlElement(ElementName = "track")]
        public List<Track> Track {
            get { return track; }
            set { track = value; }
        }
    }

	[XmlRoot(ElementName = "Backoff")]
	public class Backoff {
        private string time;

        [XmlElement(ElementName = "Time")]
        public string Time {
            get { return time; }
            set { time = value; }
        }
    }

	[XmlRoot(ElementName = "METADATA")]
	public class METADATA {
        private MDRCD mDRCD;
        private Backoff backoff;

        [XmlElement(ElementName = "MDR-CD")]
        public MDRCD MDRCD {
            get { return mDRCD; }
            set { mDRCD = value; }
        }

        [XmlElement(ElementName = "Backoff")]
        public Backoff Backoff {
            get { return backoff; }
            set { backoff = value; }
        }
    }
}
