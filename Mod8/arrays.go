package main

import "fmt"

func main() {
	var arr [3]string
	fmt.Println(arr)

	arr = [3]string("Coffee", "Coffee2", "Tea") // Assigning
	fmt.Println(arr)

	fmt.Println(arr[2])
	arr[2] = "Latte" //JUst like pop and shift in Javascript

	fmt.Println(arr)
}
