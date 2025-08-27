package io.accelerate.solutions.CHK;

import io.accelerate.runner.SolutionNotImplementedException;

public class CheckoutSolution {
    public Integer checkout(String skus) {
        if(skus.length()<1){
            return -1;
        }
        Integer count = 0;
        Integer[] skuRepeated = new Integer[4];
        String [] skusArr = skus.split(",");
        for(String sku : skusArr) {
            switch (sku.trim()) {
                case "A":
                    skuRepeated[0]++;
                    count += 50;
                    break;
                case "B":
                    skuRepeated[1]++;
                    count += 30;
                    break;
                case "C":
                    skuRepeated[2]++;
                    count += 20;
                    break;
                case "D":
                    skuRepeated[3]++;
                    count += 15;
                    break;
                default:
                    return -1;
            }
        }

        if(skuRepeated[0]){}

        return count;
    }
}


