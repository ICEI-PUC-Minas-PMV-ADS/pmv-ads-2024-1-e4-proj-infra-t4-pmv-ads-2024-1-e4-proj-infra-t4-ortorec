import { View, Text, FlatList, Image, RefreshControl, Alert} from 'react-native'
import { useEffect, useState } from 'react'
import React from 'react'
import { SafeAreaView } from 'react-native-safe-area-context'

import { images } from "../../constants"
import SearchInput from "../../components/SearchInput"
import Novidades from "../../components/Novidades"
import EstadoVazio from '@/components/EstadoVazio'
import { getAllPosts, getNewProductsPosts, getTrendingPosts } from '../../lib/appwrite'
import useAppwrite from '../../lib/useAppwrite'
import ProductCard from '../../components/ProductCard'
import Destaque from '../../components/Destaques'

const Home = () => {

  const { data: posts, refetch } = useAppwrite(getAllPosts);
  const { data: latestProducts } = useAppwrite(getNewProductsPosts);
  const { data: trendingProducts } = useAppwrite(getTrendingPosts);

  const [refreshing, setRefreshing] = useState(false)

  const onRefresh = async () => {
    setRefreshing(true);
    await refetch();
    setRefreshing(false);
  }

  console.log(posts)

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
        ListHeaderComponent={( ) => (
          <View className="my-6 px-4 space-y-6">

            <View className="justify-between items-start flex-row mb-6">

              <View>
                <Text className="font-pmedium text-sm text-secondary">
                  Bem-Vindo de volta!
                </Text>
                <Text className="text-2xl font-psemibold">
                  Usuário
                </Text>
              </View>

              <View className="mt-1.5">
                <Image
                  source={images.recomecarLogoPequeno}
                  className="w-20 h-20"
                  resizeMode="contain"
                  
                />
              </View>

            </View>

            <SearchInput/>

            <View className='w-full flex-1 pt-5 pb-8'>
              <Text className='text-secondary text-lg font-pregular mb-3'>
                Novidades!
              </Text>

              <Novidades posts={latestProducts ?? []} />
            </View>

            <View className='w-full flex-1 pt-5 pb-8'>
              <Text className='text-secondary text-lg font-pregular mb-3'>
                Destaques...
              </Text>

              <Destaque posts={trendingProducts ?? []} />
            </View>

            <Text className='text-secondary text-lg font-pregular mb-3'>
                Outros Produtos...
              </Text>

          </View>
        )}

        ListEmptyComponent={( ) => (
          <EstadoVazio
            title="Nenhum produto encontrado"
          />
        )}

        refreshControl={<RefreshControl refreshing={refreshing} onRefresh={onRefresh} />}
      />
    </SafeAreaView>
  )
}

export default Home