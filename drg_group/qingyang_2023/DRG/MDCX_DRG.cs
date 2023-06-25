namespace drg_group.qingyang_2023
{
    public class MDCX_DRG 
    {
    
        public static bool XR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR39_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT35_group(MedicalRecord record){
            return true;
        }
    
    }
}
