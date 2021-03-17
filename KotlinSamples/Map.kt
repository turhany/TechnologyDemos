// Mapping function
fun main(args: Array<String>) {
    var arr = intArrayOf(4, 2, 7, 5, 9)

    printArray(map(arr, {x -> x * x}))
    printArray(map(arr, {x -> -x}))
}


fun map(numbers: IntArray, mapping: (Int)->Int) : IntArray {
    var res = IntArray(numbers.size)

    for(i in 0..numbers.size-1)
        res[i] = mapping(numbers[i])

    return res
}

fun printArray(arr: IntArray) {
    for(num in arr)
        print("${num}\t")
    println()
}