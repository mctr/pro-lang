package main

import "fmt"

func main() {
	int_list := []int {1, 2, 2, 3, 3, 3, 4, 4, 4, 4}

	result := int_list[:1]
    	for _, v := range int_list {
		state := true
        	for _, k := range result {
			if v != k {
				state = false
			} else if v == k {
				state = true
				break
			}
		}
		if state == false {
				result = append(result, v)
			}
    	}
	// TODO
	for i, _ := range result {
		count := 0
		for j, _ := range int_list {
			if result[i] == int_list[j] {
				count += 1
			}
		}
		fmt.Println(result[i], count)
	}
}
