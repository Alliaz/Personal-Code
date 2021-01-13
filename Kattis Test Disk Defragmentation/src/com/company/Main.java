package com.company;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {

    Scanner diskSc = new Scanner(System.in);
    ArrayList charList = new ArrayList();
    ArrayList tempList = new ArrayList();
    char[] splitString;
    int dataIndex = 0;
    boolean alreadyExecuted = false;
    for(){

    }
        while () {

        String tempString = diskSc.nextLine();
        splitString = tempString.toCharArray();

        if(tempString == "") {
            alreadyExecuted = false;
        }

        for (int i = 0; i < splitString.length; i++) {
            charList.add(splitString[i]);
        }

        if (!alreadyExecuted && splitString.length > 0) {
            dataIndex = splitString.length;
            alreadyExecuted = true;
        }

        if(splitString.length > 0){
            int x = 0;
            while (x < splitString.length) {
                if (charList.get(x).equals('*') && !tempList.contains(x)) {
                    if (!charList.get(dataIndex-1).equals('*')) {
                        Collections.swap(charList, x, dataIndex - 1);
                        tempList.add(dataIndex - 1);
                        dataIndex--;
                        x++;
                    }
                    else {
                        tempList.add(dataIndex - 1);
                        dataIndex--;
                    }
                }
                else{
                    x++;
                }
            }
        }

        System.out.println(charList.toString()
                .replace("[", "")
                .replace(",", "")
                .replace(" ", "")
                .replace("]", ""));

        charList.clear();
        tempList.clear();
    }
}

