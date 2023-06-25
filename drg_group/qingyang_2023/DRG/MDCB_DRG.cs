namespace drg_group.qingyang_2023
{
    public class MDCB_DRG 
    {
    
        public static bool BC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool BD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool BE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool BL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BM19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool BJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool BT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool BY11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool BY21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool BB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BU33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BV23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BV33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BW23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BX13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BX23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BY13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BY23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool BB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BU35_group(MedicalRecord record){
            return true;
        }
    
        public static bool BV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BV25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool BW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BX15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BX25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BY15_group(MedicalRecord record){
            return true;
        }
    
        public static bool BY25_group(MedicalRecord record){
            return true;
        }
    
        public static bool BZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
