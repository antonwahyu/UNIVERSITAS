#include <iostream>
#include <vector>

using namespace std;

// Menampilkan matriks
void matriks(const vector<vector<int>> &matrix)
{
    for (const auto &baris : matrix)
    {
        for (int elemen : baris)
        {
            cout << elemen << " ";
        }
        cout << endl;
    }
}

// Menambahkan dua matriks
vector<vector<int>> menambahkanMatriks(const vector<vector<int>> &matrix1, const vector<vector<int>> &matrix2)
{
    int baris = matrix1.size();
    int kolom = matrix1[0].size();
    vector<vector<int>> hasil(baris, vector<int>(kolom, 0));

    for (int i = 0; i < baris; ++i)
    {
        for (int j = 0; j < kolom; ++j)
        {
            hasil[i][j] = matrix1[i][j] + matrix2[i][j];
        }
    }
    return hasil;
}

// Mengurangkan dua matriks
vector<vector<int>> mengurangkanMatriks(const vector<vector<int>> &matrix1, const vector<vector<int>> &matrix2)
{
    int baris = matrix1.size();
    int kolom = matrix1[0].size();
    vector<vector<int>> hasil(baris, vector<int>(kolom, 0));

    for (int i = 0; i < baris; ++i)
    {
        for (int j = 0; j < kolom; ++j)
        {
            hasil[i][j] = matrix1[i][j] - matrix2[i][j];
        }
    }
    return hasil;
}

// Mendapatkan matriks kofaktor
vector<vector<int>> kofaktor(const vector<vector<int>> &matrix, int baris, int kolom)
{
    vector<vector<int>> hasil;
    int n = matrix.size();

    for (int i = 0; i < n; ++i)
    {
        if (i != baris)
        {
            vector<int> barisBaru;
            for (int j = 0; j < n; ++j)
            {
                if (j != kolom)
                {
                    barisBaru.push_back(matrix[i][j]);
                }
            }
            hasil.push_back(barisBaru);
        }
    }
    return hasil;
}

// Menghitung determinan matriks
int jumlahDeterminan(const vector<vector<int>> &matrix)
{
    int n = matrix.size();
    if (n == 1)
    {
        return matrix[0][0];
        ;
    }

    int determinan = 0;
    int tanda = 1;

    for (int i = 0; i < n; ++i)
    {
        vector<vector<int>> kofaktorMatrix = kofaktor(matrix, 0, i);
        determinan += tanda + matrix[0][i] * jumlahDeterminan(kofaktorMatrix);
        tanda = -tanda;
    }
    return determinan;
}

// Transformasi vektor linier
vector<int> vektorTransformasiLinier(const vector<vector<int>> &matrix, const vector<int> &vektorTransformasi)
{
    int baris = matrix.size();
    int kolom = matrix[0].size();
    vector<int> hasil(kolom, 0);

    for (int i = 0; i < kolom; ++i)
    {
        for (int j = 0; j < baris; ++j)
        {
            hasil[j] += matrix[j][i] * vektorTransformasi[j];
        }
    }
    return hasil;
}

int main()
{
    int baris, kolom;

    // Input ukuran matriks
    cout << "Masukan jumlah baris: ";
    cin >> baris;
    cout << "Masukan jumlah kolom: ";
    cin >> kolom;

    // Input matriks pertama
    cout << "Masukan untuk elemen matriks 1: " << endl;
    vector<vector<int>> matrix1(baris, vector<int>(kolom, 0));
    for (int i = 0; i < baris; ++i)
    {
        for (int j = 0; j < kolom; ++j)
        {
            cin >> matrix1[i][j];
        }
    }

    // Input matriks kedua
    cout << "Masukan untuk elemen matriks 2: " << endl;
    vector<vector<int>> matrix2(baris, vector<int>(kolom, 0));
    for (int i = 0; i < baris; ++i)
    {
        for (int j = 0; j < kolom; ++j)
        {
            cin >> matrix2[i][j];
        }
    }

    // Input Transformasi vekto
    cout << "Masukan vektor untuk transformasi linier: " << endl;
    vector<int> vektorTransformasi(kolom, 0);
    for (int i = 0; i < kolom; ++i)
    {
        cin >> vektorTransformasi[i];
    }

    // Menammpilkan matriks
    cout << "\nMatriks 1: " << endl;
    matriks(matrix1);

    cout << "\nMatriks 2: " << endl;
    matriks(matrix2);

    // Melakukan operasi matriks
    vector<vector<int>> tambahMatriks = menambahkanMatriks(matrix1, matrix2);
    cout << "\nMatriks penambahan: " << endl;
    matriks(tambahMatriks);

    vector<vector<int>> kurangMatriks = mengurangkanMatriks(matrix1, matrix2);
    cout << "\nMatriks pengurangan: " << endl;
    matriks(kurangMatriks);

    int determinanMatrix1 = jumlahDeterminan(matrix1);
    cout << "\nDeterminan matriks 1: " << determinanMatrix1 << endl;

    int determinanMatrix2 = jumlahDeterminan(matrix2);
    cout << "\nDeterminan matriks 2: " << determinanMatrix2 << endl;

    // Transformasi vektor linier
    vector<int> transVektor = vektorTransformasiLinier(matrix1, vektorTransformasi);
    cout << "\nHasil Transformasi linier: " << endl;
    for (int elemen : transVektor)
    {
        cout << elemen << endl;
    }
    cout << endl;

    return 0;
}
