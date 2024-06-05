import { useEffect, useState } from "react";
import { useLocalSearchParams } from "expo-router";
import { View, Text, FlatList, RefreshControl } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";

import useAppwrite from "../../lib/useAppwrite";
import { getAllPosts, searchPosts } from "../../lib/appwrite";
import { EstadoVazio, SearchInput } from "../../components";
import ProductCard from "../../components/ProductCard";


const Busca = () => {

  const { query } = useLocalSearchParams();
  const { data: posts, refetch } = useAppwrite(
    () => searchPosts(query));

  useEffect(() => {
    refetch();
  }, [query]);

  return (
    <SafeAreaView className='h-full'>
      <FlatList
        data={posts}
        keyExtractor={(item) => item.$id}
        renderItem={({ item }) => (
          <ProductCard
            nome={item.nome}
            foto={item.foto}
            preco={item.preco}
          />
        )}
        ListHeaderComponent={() => (
          <>
            <View className="flex my-6 px-4">
              <Text className="font-pmedium text-sm text-secondary">
                Resultados da Busca...
              </Text>
              <Text className="text-2xl font-psemibol mt-1">
                {query}
              </Text>

              <View className="mt-6 mb-8">
                <SearchInput initialQuery={query} refetch={refetch} />
              </View>
            </View>
          </>
        )}
        ListEmptyComponent={() => (
          <EstadoVazio
            title="Nenhum produto encontrado..."
          />
        )}
      />
    </SafeAreaView>
  )
}

export default Busca