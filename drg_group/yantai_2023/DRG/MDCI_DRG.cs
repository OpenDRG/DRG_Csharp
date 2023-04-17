namespace drg_group.yantai_2023
{
    public class MDCI_DRG 
    {
    
        public static bool IB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC49_group(MedicalRecord record){
            return true;
        }
    
        public static bool IE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF49_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF59_group(MedicalRecord record){
            return true;
        }
    
        public static bool IH19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IU31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ID13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IG13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ID15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IG15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IV15_group(MedicalRecord record){
            return true;
        }
    
    }
}
