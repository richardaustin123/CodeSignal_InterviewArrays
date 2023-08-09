// Link:
// https://app.codesignal.com/interview-practice/question/pMvymcahZ8dY4g75q/description

int solution(int[] a) {
    int dupIndex = a.Length; 
    int dupNum = -1;
    
    for (int i = 0; i < a.Length; i++) {
        for (int j = i + 1; j < a.Length; j++) {
            if (a[i] == a[j] && j < dupIndex) { 
                dupIndex = j;
                dupNum = a[j];
                break; // Stop checking once a duplicate is found
            }
        }
    }
    return dupNum;
}

// int solution(int[] a) {
//     int dupIndex = a.Length + 1;
//     int dupNum = -1;
//     int checkNumIndex;
//     int checkNum;
    
//     for (int i = 0; i < a.Length; i++) {
//         checkNum = a[i];
//         checkNumIndex = i;
        
//         for (int j = 0; j < a.Length; j++) {
//             if (checkNumIndex != a[j]) {
//                 if (checkNum == a[j]) {
//                     if (j < dupIndex) {
//                         dupIndex = j;
//                         dupNum = a[j];
//                     }
//                 }
//             } else {
//                 break;
//             }
//         }
//     }
//     return dupNum;
// }
