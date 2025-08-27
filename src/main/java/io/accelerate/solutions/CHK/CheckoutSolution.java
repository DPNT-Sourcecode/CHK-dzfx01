package io.accelerate.solutions.CHK;

import io.accelerate.runner.SolutionNotImplementedException;

import java.util.HashMap;
import java.util.Map;

public class CheckoutSolution {
    public Integer checkout(String skus) {
        if(skus.length()==0){
            return 0;
        }
        Integer count = 0;
        Map<Character, Integer> skuRepeated = new HashMap<>();
        char [] skusArr = skus.toCharArray();
        for(char sku : skusArr) {
            skuRepeated.put(sku, skuRepeated.getOrDefault(sku, 0) + 1);
        }

        for(Map.Entry<Character, Integer> value : skuRepeated.entrySet()){
            char sku = value.getKey();
            int repeated = value.getValue();
            switch (sku){
                case 'A':
                    count+= (repeated / 3) * 130;
                    count+= (repeated % 3) * 50;
                    break;
                case 'B':
                    count+= (repeated / 2) * 45;
                    count+= (repeated % 2) * 30;
                    break;
                case 'C':
                    count+= repeated * 20;
                    break;
                case 'D':
                    count+= repeated * 15;
                    break;
                default:
                    return -1;
            }
        }
        return count;
    }
}


