// Defines an array of 10 doubles and for each number prints if its higher or lower than average
fun main(args: Array<String>) {
    var numbers = DoubleArray(10)
    var sum = 0.0
    var average = 0.0

    for(i in 0..numbers.size - 1) {
        numbers[i] = Math.random() * 10
        sum += numbers[i]
    }

    average = sum / numbers.size
    println("the average is ${average}")

    for(num in numbers)
        println("${num} is " + if(num > average)
                                    "higher"
                                else
                                    "lower")
}