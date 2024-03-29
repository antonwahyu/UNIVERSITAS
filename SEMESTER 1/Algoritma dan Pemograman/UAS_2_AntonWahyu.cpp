#include <iostream>
#include <iomanip>

using namespace std;

// Fungsi untuk menghitung besar potongan diskon
int potong(int belanja) {
    int diskon = 0;

    if (belanja >= 1000000 && belanja <= 5000000) {
        diskon = 0.2 * belanja;
    } else if (belanja > 5000000) {
        diskon = 0.35 * belanja;
    }

    return diskon;
}

int main() {
    int belanja;
    char lanjut;

    do {
        cout << "Besar pembelian barang (Rp): ";
        cin >> belanja;

        int diskon = potong(belanja);

        cout << "---------------------------------------------------" << endl;
        cout << "Besar pembelian barang :\t\t Rp " << belanja << endl;
        cout << "Besar diskon yang diberikan :\t\t Rp " << diskon << endl;
        cout << "---------------------------------------------------" << endl;

        // Menghitung total yang harus dibayar setelah diskon
        int totalBayar = belanja - diskon;
        cout << "Besar harga yang harus dibayarkan : \t Rp " << totalBayar << endl;
        cout << endl << endl;
        // Meminta pengguna apakah ingin melanjutkan
        cout << "Apakah ingin menghitung diskon untuk pembelian lain? (y/n): ";
        cin >> lanjut;
    } while (lanjut == 'y' || lanjut == 'Y');

    return 0;
}
