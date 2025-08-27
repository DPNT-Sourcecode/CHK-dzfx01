package io.accelerate.solutions.CHK;

import io.accelerate.runner.SolutionNotImplementedException;

public class CheckoutSolution {
    public Integer checkout(String skus) {
        if(skus.length()<1){
            return -1;
        }
        Integer count = 0;
        Integer[] skuRepeated = new Integer[4];
        char [] skusArr = skus.toCharArray();
        for(char sku : skusArr) {
            switch (sku) {
                case 'A':
                    skuRepeated[0]++;
                    break;
                case 'B':
                    skuRepeated[1]++;
                    break;
                case 'C':
                    skuRepeated[2]++;
                    break;
                case 'D':
                    skuRepeated[3]++;
                    break;
                default:
                    return -1;
            }
        }

        for(int i=0;i<skuRepeated.length;i++){
            
        }


        return count;
    }
}
