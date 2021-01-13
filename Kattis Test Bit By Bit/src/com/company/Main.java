package com.company;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true)
        {
            int insSequences = sc.nextInt();
            if (insSequences == 0){
                break;
            }

            char[] charArray = new char[32];
            for(int i = 0; i < 32; i++){
                charArray[i] = '?';
            }

            while (insSequences --> 0) {
                String manipulationInstr = sc.next();

                if (manipulationInstr.contains("CLEAR")) {
                    charArray[sc.nextInt()] = '0';
                }
                else if (manipulationInstr.contains("SET")){
                    charArray[sc.nextInt()] = '1';
                }
                else if (manipulationInstr.contains("AND")) {
                    int i = sc.nextInt();
                    int j = sc.nextInt();
                    charArray[i] = ANDGateChecker(charArray[i], charArray[j]);
                }
                else if (manipulationInstr.contains("OR")) {
                    int i = sc.nextInt();
                    int j = sc.nextInt();
                    charArray[i] = ORGateChecker(charArray[i], charArray[j]);
                }
            }
            StringBuilder sb = new StringBuilder();
            System.out.println(sb.append(charArray).reverse());
        }
        sc.close();
    }

    public static char ORGateChecker(char i, char j)
    {
        if(i == '1' || j == '1'){
            return '1';
        }
        if(i == '?' || j == '?'){
            return '?';
        }
        return '0';
    }
    public static char ANDGateChecker(char i, char j)
    {
        if(i == '0' || j == '0'){
            return '0';
        }
        if(i == '?' || j == '?'){
            return '?';
        }
        return '1';
    }
}
