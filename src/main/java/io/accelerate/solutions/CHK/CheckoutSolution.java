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
                    break;
                case "B":
                    skuRepeated[1]++;
                    break;
                case "C":
                    skuRepeated[2]++;
                    break;
                case "D":
                    skuRepeated[3]++;
                    break;
                default:
                    return -1;
            }
        }


        return count;
    }
}



