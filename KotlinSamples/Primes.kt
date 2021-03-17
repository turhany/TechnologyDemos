// Generates a random number and prints all primes
fun main(args: Array<String>) {
    var num = (Math.random() * 999).toInt() + 2
    var isPrime = true

    println("The number is: ${num}")
    for(n in 2..num) {
        isPrime = true
        for(i in 2..n-1)
            if(n % i == 0) {
                isPrime = false
                break
            }
        if(isPrime)
            println(n)
    }
}