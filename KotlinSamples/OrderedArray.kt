fun main(args: Array<String>) {
    var arr = intArrayOf(1, 2, 3, 4, 5)
    println(isOrdered(arr))
    println(isOrdered(arr, false))

}

fun isOrdered(numbers: IntArray, asc: Boolean = true) : Boolean {
    for(i in 0..numbers.size - 2)
        if(asc && numbers[i] > numbers[i+1] ||
                !asc && numbers[i] < numbers[i+1])
            return false
    return true
}