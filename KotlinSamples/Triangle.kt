// Random Triangle

fun main(args: Array<String>) {
    var a = (Math.random() * 20).toInt();
    var b = (Math.random() * 20).toInt();
    var c = (Math.random() * 20).toInt();

    var res = "The lengths $a, $b, $c "

    res += if(a + b > c && a + c > b && b + c > a)
        "represent a valid triangle"
    else
        "cannot represent a valid triangle"
    println(res)
}