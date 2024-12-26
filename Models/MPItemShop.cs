using System.Collections.Generic;

namespace Apollo.Models
{
    public class MPItemShopModel
    {
        public ShopDataModel shopData { get; set; }
    }
    public class ShopDataModel
    {
        public List<ShopSectionModel> sections { get; set; }
    }

    public class ShopSectionModel
    {
        public ShopMetadataModel metadata { get; set; }
        public string displayName { get; set; }
        public string sectionID { get; set; }
        public string category { get; set; }
    }
    public class ShopMetadataModel
    {
        public List<OfferGroupModel> offerGroups { get; set; }
        public List<StackRankModel> stackRanks { get; set; }
    }
    public class StackRankModel
    {
        public int stackRankValue { get; set; }
        public string _type { get; set; }
        public string context { get; set; }
        public string productTag { get; set; }
        public string startDate { get; set; }
    }
    public class OfferGroupModel
    {
        public bool bUseWidePreview { get; set; }
        public string displayType { get; set; }
        public string _type { get; set; }
        public string offerGroupId { get; set; }
        public List<StackRankModel> stackRanks { get; set; }
    }
}